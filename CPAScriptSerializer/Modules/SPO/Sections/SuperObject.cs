﻿using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.SPO.Commands.SuperObject;

namespace CPAScriptSerializer.CPAScriptSerializer.Modules.SPO.Sections {
   public class SuperObject : CPAScriptSection {
      public SuperObject(string sectionId) : base(sectionId) { }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         {nameof(AddChild), typeof(AddChild)},
         {nameof(LinkedObject), typeof(LinkedObject)},
         {nameof(PutMatrix), typeof(PutMatrix)},
         {nameof(Flags), typeof(Flags)},
         {nameof(Transparency), typeof(Transparency)},
      };
      public override Type CommandTypeFallback(string name) => null;
   }
}
