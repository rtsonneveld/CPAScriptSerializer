using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.SND.Commands.CSB;
using CPAScriptSerializer.Modules.SND.Commands.CSB.SndResourceDiskOptions;
using CPAScriptSerializer.Modules.SND.Commands.CSB.SndResourceDiskOptions.General;
using CPAScriptSerializer.Modules.SND.Enums;
using ResSample = CPAScriptSerializer.Modules.SND.Commands.CSB.SndResourceDiskOptions.ResSample;
using ResTheme = CPAScriptSerializer.Modules.SND.Commands.CSB.SndResourceDiskOptions.ResTheme;
using ResRandom = CPAScriptSerializer.Modules.SND.Commands.CSB.SndResourceDiskOptions.ResRandom;
using ResSequence = CPAScriptSerializer.Modules.SND.Commands.CSB.SndResourceDiskOptions.ResSequence;
using ResSwitch = CPAScriptSerializer.Modules.SND.Commands.CSB.SndResourceDiskOptions.ResSwitch;

namespace CPAScriptSerializer.Modules.SND.Sections.CSB {
   public class SndResourceDisk : CPAScriptSection {

      public SndResourceDisk(string sectionId, string sectionType) : base(sectionId, sectionType) { }

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
         { nameof(ResSample.SetFlags), typeof(ResSample.SetFlags) },
         { "Flags", typeof(ResSample.SetFlags) },
         { "SetLoop", typeof(SetOptionBool) },
         { nameof(ResSample.SetLoopData), typeof(ResSample.SetLoopData) },
         { nameof(ResSample.SetStartLoop), typeof(ResSample.SetStartLoop) },
         { nameof(ResSample.SetLoopLength), typeof(ResSample.SetLoopLength) },
         { "SetPitchable", typeof(SetOptionBool) },
         { "SetVolable", typeof(SetOptionBool) },
         { "SetPanable", typeof(SetOptionBool) },
         { "SetSpacable", typeof(SetOptionBool) },
         { "SetReverbable", typeof(SetOptionBool) },
         { "SetStreaming", typeof(SetOptionBool) },
         { nameof(ResSample.SetSampleFrequency), typeof(ResSample.SetSampleFrequency) },
         { nameof(ResSample.SetSampleChannelNumber), typeof(ResSample.SetSampleChannelNumber) },
         { nameof(ResSample.SetSampleResolution), typeof(ResSample.SetSampleResolution) },
         { nameof(ResSample.SetZipFormat), typeof(ResSample.SetZipFormat) },

         /* ResTheme */
         { nameof(ResTheme.SetFadeDuration), typeof(ResTheme.SetFadeDuration) },
         { nameof(ResTheme.SetNbMainLoop), typeof(ResTheme.SetNbMainLoop) },

         /* ResRandom */
         { nameof(ResRandom.SetProbNothing), typeof(ResRandom.SetProbNothing) },
         { nameof(ResRandom.SetNothingCanBeChoosenTwice), typeof(ResRandom.SetNothingCanBeChoosenTwice) },
         
         /* ResSwitch */
         {nameof(ResSwitch.SwitchInfoType), typeof(ResSwitch.SwitchInfoType)},
         {nameof(ResSwitch.SwitchDefaultValue), typeof(ResSwitch.SwitchDefaultValue)},
         {nameof(ResSwitch.SetSwitchDynamic), typeof(ResSwitch.SetSwitchDynamic)},
         {nameof(ResSwitch.SetMaintainIfSwitched), typeof(ResSwitch.SetMaintainIfSwitched)},
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
               case EnumResourceType.TYPE_SEQUENCE: return typeof(ResSequence.SetNumberOfElements);
               case EnumResourceType.TYPE_SWITCH: return typeof(ResSwitch.SetNumberOfElements);
            }
         }

         return null;
      }
   }
}
