using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.Editor.TGM.Commands;

namespace CPAScriptSerializer.Modules.Editor.TGM.Sections {
   public class MechanicalMaterial : CPAScriptSection {
      public MechanicalMaterial(string sectionId) : base(sectionId)
      {
      }

      [UnusedByCPA] private const string Adhesion = "Adhesion";
      [UnusedByCPA] private const string Absorption = "Absorption";
      [UnusedByCPA] private const string Friction = "Friction";
      [UnusedByCPA] private const string Slide = "Slide";
      [UnusedByCPA] private const string Progression = "Progression";
      [UnusedByCPA] private const string PenetrationSpeed = "PenetrationSpeed";
      [UnusedByCPA] private const string PenetrationMax = "PenetrationMax";
      private const string BaseSlide = "BaseSlide";
      private const string BaseRebound = "BaseRebound";

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         {Adhesion, typeof(MaterialProperty)},
         {Absorption, typeof(MaterialProperty)},
         {Friction, typeof(MaterialProperty)},
         {Slide, typeof(MaterialProperty)},
         {Progression, typeof(MaterialProperty)},
         {PenetrationSpeed, typeof(MaterialProperty)},
         {PenetrationMax, typeof(MaterialProperty)},
         {BaseSlide, typeof(MaterialProperty)},
         {BaseRebound, typeof(MaterialProperty)},
      };
   }
}
