using System;
using System.Collections.Generic;
using System.Text;

namespace CPAScriptSerializer.Modules.GAM.Enums {
   [ReplaceUnderscoresEnum("")]
   public enum EnumObjectTypeFrame {
      _Undefined,
      _3dObject,
      _Morphed,
      _Light,
      _SoundEvent,
      _CameraEvent,
      _GenericEvent,
      _GenerateEvent,
      _MechanicEvent,
      _Fake,
      _Empty,
      _EmptyObject, // Old?
   }
}
