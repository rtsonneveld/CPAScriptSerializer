using System;
using System.Collections.Generic;
using CPAScriptSerializer.Modules.IPT.Commands;
using CPAScriptSerializer.Modules.IPT.Commands.Input;
using CPAScriptSerializer.Modules.IPT.Commands.Logical;

namespace CPAScriptSerializer.Modules.IPT.Sections
{
   public class InputAction : CPAScriptSection {
      
      public InputAction(string sectionId) : base(sectionId)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         // Logical Operators
         {nameof(And), typeof(And)},
         {nameof(Or), typeof(Or)},
         {nameof(Not), typeof(Not)},

         // Keys
         {KeyCommand.KeyPressed, typeof(KeyCommand) },
         {KeyCommand.KeyReleased, typeof(KeyCommand) },
         {KeyCommand.KeyJustPressed, typeof(KeyCommand) },
         {KeyCommand.KeyJustReleased, typeof(KeyCommand) },

         // Actions
         { ActionCommand.ActionValidated, typeof(ActionCommand) },
         { ActionCommand.ActionInvalidated, typeof(ActionCommand) },

         // Joystick
         { nameof(JoyAxeValue), typeof(JoyAxeValue) },

         { nameof(JoyCommand.JoyPressed), typeof(JoyCommand) },
         { nameof(JoyCommand.JoyReleased), typeof(JoyCommand) },
         { nameof(JoyCommand.JoyJustPressed), typeof(JoyCommand) },
         { nameof(JoyCommand.JoyJustReleased), typeof(JoyCommand) },

         // Pad
         { nameof(PadCommand.PadPressed), typeof(PadCommand) },
         { nameof(PadCommand.PadReleased), typeof(PadCommand) },
         { nameof(PadCommand.PadJustPressed), typeof(PadCommand) },
         { nameof(PadCommand.PadJustReleased), typeof(PadCommand) },

         { nameof(JoyOrPadCommand.JoyOrPadPressed), typeof(JoyOrPadCommand) },
         { nameof(JoyOrPadCommand.JoyOrPadReleased), typeof(JoyOrPadCommand) },
         { nameof(JoyOrPadCommand.JoyOrPadJustPressed), typeof(JoyOrPadCommand) },
         { nameof(JoyOrPadCommand.JoyOrPadJustReleased), typeof(JoyOrPadCommand) },

      };

      
   }
}