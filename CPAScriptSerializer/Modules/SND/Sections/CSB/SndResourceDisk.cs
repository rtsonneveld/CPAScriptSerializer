using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.SND.Commands.CSB;
using CPAScriptSerializer.Modules.SND.Commands.CSB.SndResourceDiskOptions;
using CPAScriptSerializer.Modules.SND.Commands.CSB.SndResourceDiskOptions.General;
using CPAScriptSerializer.Modules.SND.Commands.CSB.SndResourceDiskOptions.ResRandom;
using CPAScriptSerializer.Modules.SND.Commands.CSB.SndResourceDiskOptions.ResSample;
using CPAScriptSerializer.Modules.SND.Commands.CSB.SndResourceDiskOptions.ResTheme;
using CPAScriptSerializer.Modules.SND.Enums;
using ResSample = CPAScriptSerializer.Modules.SND.Commands.CSB.SndResourceDiskOptions.ResSample;
using ResTheme = CPAScriptSerializer.Modules.SND.Commands.CSB.SndResourceDiskOptions.ResTheme;
using ResRandom = CPAScriptSerializer.Modules.SND.Commands.CSB.SndResourceDiskOptions.ResRandom;

namespace CPAScriptSerializer.Modules.SND.Sections.CSB {
   public class SndResourceDisk : CPAScriptSection {

      public SndResourceDisk(string sectionId) : base(sectionId) { }

      [CommandParameter(0)]
      public EnumResourceType ResourceType;

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         /* General */
         {nameof(SetDataOffset), typeof(SetDataOffset)},
         {nameof(SetDataSize), typeof(SetDataSize)},
         {nameof(SetFileName), typeof(SetFileName)},
         {nameof(SetStorage), typeof(SetStorage)},
         {nameof(SetVolume), typeof(SetVolume)},

         /* ResSample */
         { nameof(SetFlags), typeof(SetFlags) },
         { "Flags", typeof(SetFlags) },
         { "SetLoop", typeof(SetOptionBool) },
         { nameof(SetLoopData), typeof(SetLoopData) },
         { nameof(SetStartLoop), typeof(SetStartLoop) },
         { nameof(SetLoopLength), typeof(SetLoopLength) },
         { "SetPitchable", typeof(SetOptionBool) },
         { "SetVolable", typeof(SetOptionBool) },
         { "SetPanable", typeof(SetOptionBool) },
         { "SetSpacable", typeof(SetOptionBool) },
         { "SetReverbable", typeof(SetOptionBool) },
         { "SetStreaming", typeof(SetOptionBool) },
         { nameof(SetSampleFrequency), typeof(SetSampleFrequency) },
         { nameof(SetSampleChannelNumber), typeof(SetSampleChannelNumber) },
         { nameof(SetSampleResolution), typeof(SetSampleResolution) },
         { nameof(SetZipFormat), typeof(SetZipFormat) },

         /* ResTheme */
         { nameof(SetFadeDuration), typeof(SetFadeDuration) },
         { nameof(SetNbMainLoop), typeof(SetNbMainLoop) },

         /* ResRandom */
         { nameof(SetProbNothing), typeof(SetProbNothing) },
         { nameof(SetNothingCanBeChoosenTwice), typeof(SetNothingCanBeChoosenTwice) },
      };

      public override Type CommandTypeFallback(string name)
      {
         // Annoyingly, "SndResourceDisk" sections can have different types,
         // which changes how the parameters are parsed...
         if (name == "SetParameters") {
            switch (ResourceType) {
               case EnumResourceType.TYPE_SAMPLE: return typeof(ResSample.SetParameters);
               case EnumResourceType.TYPE_THEME: return typeof(ResTheme.SetParameters);
            }
         }

         if (name == "SetNumberOfElements") {
            switch (ResourceType) {
               case EnumResourceType.TYPE_THEME: return typeof(ResTheme.SetNumberOfElements);
               case EnumResourceType.TYPE_RANDOM: return typeof(ResRandom.SetNumberOfElements);
            }
         }

         return null;
      }
   }
}
