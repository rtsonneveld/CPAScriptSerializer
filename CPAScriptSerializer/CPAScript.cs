using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer
{
   /*
   #define SCR_CC_c_Cfg_NameSeparator          '^'
   #define SCR_CC_sz_Cfg_NameSeparator         "^"
   #define SCR_CC_c_Cfg_SectionBegMark         '{'
   #define SCR_CC_c_Cfg_SectionEndMark         '}'
   #define SCR_CC_c_Cfg_SectionIdMark          ':'
   #define SCR_CC_sz_Cfg_SectionIdMark         ":"
   #define SCR_CC_c_Cfg_DirectiveMark          '$'
   #define SCR_CC_c_Cfg_CommentMark            ';'
   #define SCR_CC_c_Cfg_CommentMark1           '#'
   #define SCR_CC_c_Cfg_ParamSeparator         ','
   #define SCR_CC_c_Cfg_FormatBegMark          '['
   #define SCR_CC_c_Cfg_PostFormatBegMark      ';'
   #define SCR_CC_c_Cfg_PostFormatEndMark      ';'
   #define SCR_CC_c_Cfg_FormatEndMark          ']'
   #define SCR_CC_c_Cfg_ParamBegMark           '('
   #define SCR_CC_c_Cfg_ParamEndMark           ')'
   #define SCR_CC_c_Cfg_StringMark             '"'
   #define SCR_CC_c_Cfg_VarMark                '@'
   #define SCR_CC_C_Cfg_NoChar                 '\0'
   #define SCR_CC_C_Cfg_EOL                    '\n'
   #define SCR_CC_C_Cfg_EmptyParameter         0x01

    *  Format specifiers/
    *  'F' for Format.
   #define SCR_CF_c_Cfg_ScanfSeparator         ','
   #define SCR_CF_c_Cfg_FormatArray            'a'
   #define SCR_CF_c_Cfg_FormatArrayByte        'c'
   #define SCR_CF_c_Cfg_FormatArrayShort       'w'
   #define SCR_CF_c_Cfg_FormatArrayLong        'l'
   #define SCR_CF_c_Cfg_FormatArrayInt         'i'
   #define SCR_CF_c_Cfg_FormatArrayFloat       'f'
   #define SCR_CF_c_Cfg_FormatArrayDouble      'd'
   #define SCR_CF_c_Cfg_FormatArrayBoolean     'b'
   #define SCR_CF_c_Cfg_FormatArrayDisEna      'e'
   #define SCR_CF_c_Cfg_FormatArrayReferences  'r'
   #define SCR_CF_c_Cfg_FormatScanf            '%'
   */

   /// <summary>
   /// The SCR module in CPA allows for parsing and writing of scripts using a system of callbacks
   /// Each module can register callbacks
   /// Each line is read in SCR_Pars.c, fn_i_Pars_Line
   /// </summary>
   public abstract class CPAScript
   {
      public const char MarkSectionBegin = '{';
      public const char MarkSectionEnd = '}';
      public const char MarkSectionId = ':';
      public const char MarkDirective = '$';
      public const char MarkComment = ';';
      public const char MarkParamBegin = '(';
      public const char MarkParamEnd = ')';
      public const char MarkParamSeparator = ',';
      public const char MarkFormatBegin = '[';
      public const char MarkFormatEnd = ']';
      public const char MarkString = '\"';
      public const char IndentCharacter = '\t';

      public List<CPAScriptItem> Items;

      public CPAScriptSection GenerateSection(string sectionType, string sectionId)
      {
         if (!SectionTypes.ContainsKey(sectionType)) {
            throw new ArgumentException($"Unknown section type {sectionType}");
         }

         var constructor = SectionTypes[sectionType].GetConstructor(new Type[] { typeof(string) });
         if (constructor != null) {
            return Activator.CreateInstance(SectionTypes[sectionType], sectionId) as CPAScriptSection;
         }

         return null;
      }

      /// <summary>
      /// Types must inherit from CPAScriptSection
      /// </summary>
      public abstract Dictionary<string, Type> SectionTypes { get; }

      public void Read(Stream s)
      {
         Items = new List<CPAScriptItem>();

         using StreamReader reader = new StreamReader(s);
         while (!reader.EndOfStream) {
            ParseLine(reader.ReadLine(), reader);
         }
      }

      public void Write(Stream s)
      {
         using StreamWriter writer = new StreamWriter(s);

         int indent = 0;

         foreach (var item in Items) {
            item.Write(ref indent, writer);
         }

         writer.Flush();
         writer.Close();
      }

      private void ParseLine(string line, StreamReader reader)
      {
         if (string.IsNullOrWhiteSpace(line)) {
            return;
         }

         CPAScriptItem item = null;

         switch (line[0]) {
            case MarkSectionBegin:

               CPAScriptSection.Parse(line, out string sectionType, out string sectionId);
               item = GenerateSection(sectionType, sectionId);

               if (item == null) {
                  throw new ArgumentException($"Unknown section type {sectionType}");
               }

               break;

            case MarkDirective:
               item = new CPAScriptDirective();

               break;
            case MarkComment:

               item = new CPAScriptComment();

               break;
            default: break;
         }

         if (item != null) {
            item.Read(this, null, reader, line);
            Items.Add(item);
         } else {
            Debug.WriteLine($"Warning: unable to parse line: {line}");
         }
      }

      public static string Indent(int indent)
      {
         return new string(IndentCharacter, indent);
      }
   }
}