using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.AI.Commands.DEC;
using CPAScriptSerializer.Modules.AI.Commands.DEC.Variables;

namespace CPAScriptSerializer.Modules.AI.Sections.DEC {
   public class CreateVariables : CPAScriptSection
   {

      [CommandParameter(0)] public int DsgMemSize;
      [CommandParameter(1)] public int NumberOfVariables;

      public CreateVariables(string sectionId) : base(sectionId)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         {Commands.DEC.Variables._0To255.CommandName, typeof(Commands.DEC.Variables._0To255)},
         {Commands.DEC.Variables._0To65535.CommandName, typeof(Commands.DEC.Variables._0To65535)},
         {nameof(Commands.DEC.Variables._128To127), typeof(Commands.DEC.Variables._128To127)},
         {nameof(Commands.DEC.Variables._32768To32767), typeof(Commands.DEC.Variables._32768To32767)},

         {nameof(Commands.DEC.Variables.Action), typeof(Commands.DEC.Variables.Action)},
         {nameof(Commands.DEC.Variables.Boolean), typeof(Commands.DEC.Variables.Boolean)},
         {nameof(Commands.DEC.Variables.Capability), typeof(Commands.DEC.Variables.Capability)},
         {nameof(Commands.DEC.Variables.Comport), typeof(Commands.DEC.Variables.Comport)},
         {nameof(Commands.DEC.Variables.Float), typeof(Commands.DEC.Variables.Float)},
         {nameof(Commands.DEC.Variables.GameMaterial), typeof(Commands.DEC.Variables.GameMaterial)},
         {nameof(Commands.DEC.Variables.Graph), typeof(Commands.DEC.Variables.Graph)},
         {nameof(Commands.DEC.Variables.Integer), typeof(Commands.DEC.Variables.Integer)},
         {nameof(Commands.DEC.Variables.List), typeof(Commands.DEC.Variables.List)},
         {nameof(Commands.DEC.Variables.Perso), typeof(Commands.DEC.Variables.Perso)},
         {nameof(Commands.DEC.Variables.PositiveInteger), typeof(Commands.DEC.Variables.PositiveInteger)},
         {nameof(Commands.DEC.Variables.SuperObject), typeof(Commands.DEC.Variables.SuperObject)},
         {nameof(Commands.DEC.Variables.Text), typeof(Commands.DEC.Variables.Text)},
         {nameof(Commands.DEC.Variables.Vector), typeof(Commands.DEC.Variables.Vector)},
         {nameof(Commands.DEC.Variables.WayPoint), typeof(Commands.DEC.Variables.WayPoint)},

         // Arrays
         {nameof(Commands.DEC.Variables.FloatArray), typeof(Commands.DEC.Variables.FloatArray)},
         {nameof(Commands.DEC.Variables.IntegerArray), typeof(Commands.DEC.Variables.IntegerArray)},
         {nameof(Commands.DEC.Variables.PersoArray), typeof(Commands.DEC.Variables.PersoArray)},
         {nameof(Commands.DEC.Variables.TextArray), typeof(Commands.DEC.Variables.TextArray)},
         {nameof(Commands.DEC.Variables.VectorArray), typeof(Commands.DEC.Variables.VectorArray)},
         {nameof(Commands.DEC.Variables.WayPointArray), typeof(Commands.DEC.Variables.WayPointArray)},

         // SAI
         {nameof(TypeInitVariable), typeof(TypeInitVariable)},
         {nameof(TypeSaveVariable), typeof(TypeSaveVariable)},
      };

      public override Type CommandTypeFallback(string name) => null;
   }
}
