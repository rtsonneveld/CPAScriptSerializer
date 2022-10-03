using System;
using System.Collections.Generic;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.AI.Commands.RULRFX.Nodes;

namespace CPAScriptSerializer.Modules.AI.Sections.RULRFX.CreateIntelligence_.CreateComport_ {
   public class CreateRule : CPAScriptSection
   {

      [CommandParameter(0)] public int Index;
      [CommandParameter(1)] public int NodeCount;
      // TODO: enforce NodeCount

      public CreateRule(string sectionId) : base(sectionId)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         {nameof(KeyWord), typeof(KeyWord)},
         {nameof(Condition), typeof(Condition)},
         {nameof(MetaAction), typeof(MetaAction)},
         {nameof(Field), typeof(Field)},
         {nameof(Constant), typeof(Constant)},
         {nameof(ConstantRef), typeof(ConstantRef)},
         {nameof(Operator), typeof(Operator)},
         {nameof(Function), typeof(Function)},
         {nameof(Procedure), typeof(Procedure)},
         {nameof(DsgVar), typeof(DsgVar)},
         {nameof(DsgVarRef), typeof(DsgVarRef)},
         {nameof(Real), typeof(Real)},
         {nameof(RealRef), typeof(RealRef)},
         {nameof(BeginMacro), typeof(BeginMacro)},
         {nameof(EndMacro), typeof(EndMacro)},
         {nameof(Vector), typeof(Vector)},
         {nameof(ConstantVector), typeof(ConstantVector)},
         {nameof(PersoRef), typeof(PersoRef)},
         {nameof(ActionRef), typeof(ActionRef)},
         {nameof(WayPoint), typeof(WayPoint)},
         {nameof(Module ), typeof(Module )},
         {nameof(DsgVarId), typeof(DsgVarId)},
         {nameof(ComportRef), typeof(ComportRef)},
         {nameof(Button), typeof(Button)},
         {nameof(String), typeof(String)},
         {nameof(Mask), typeof(Mask)},
         {nameof(LipSynchroRef), typeof(LipSynchroRef)},
         {nameof(ObjectTableRef), typeof(ObjectTableRef)},
         {nameof(SectorRef ), typeof(SectorRef )},
         {nameof(SuperObjectRef ), typeof(SuperObjectRef )},
         {nameof(FamilyRef), typeof(FamilyRef)},
         {nameof(ModuleRef), typeof(ModuleRef)},
         {nameof(SoundEventRef), typeof(SoundEventRef)},
         {nameof(TextRef), typeof(TextRef)},
         //{nameof(ParticleGenerator), typeof(ParticleGenerator)},
         {nameof(GameMaterialRef), typeof(GameMaterialRef)},
         {nameof(Color), typeof(Color)},
         {nameof(ModelRef), typeof(ModelRef)},
         {nameof(Light), typeof(Light)},
         {nameof(CapsRef), typeof(CapsRef)},
         {nameof(GraphRef), typeof(GraphRef)},
         {nameof(MacroRef), typeof(MacroRef)},
      };

      public override Type CommandTypeFallback(string name) => null;
   }
}
