﻿using System;
using System.Collections.Generic;
using System.Text;
// ReSharper disable InconsistentNaming

namespace CPAScriptSerializer.Modules.AI.Enums {
   public enum EnumFunction {
      Func_GetPersoAbsolutePosition,
      Func_GetMyAbsolutePosition,
      Func_GetAngleAroundZToPerso,
      Func_DistanceToPerso,
      Func_DistanceXToPerso,
      Func_DistanceYToPerso,
      Func_DistanceZToPerso,
      Func_DistanceXYToPerso,
      Func_DistanceXZToPerso,
      Func_DistanceYZToPerso,
      Func_DistanceToPersoCenter,
      Func_DistanceXToPersoCenter,
      Func_DistanceYToPersoCenter,
      Func_DistanceZToPersoCenter,
      Func_DistanceXYToPersoCenter,
      Func_DistanceXZToPersoCenter,
      Func_DistanceYZToPersoCenter,
      Func_DistanceToWP,
      Func_GetWPAbsolutePosition,
      Func_Int,
      Func_RandomInt,
      Func_Real,
      Func_Sinus,
      Func_Cosinus,
      Func_Square,
      Func_SquareRoot,
      Func_RandomReal,
      Func_MinimumReal,
      Func_MaximumReal,
      Func_DegreeToRadian,
      Func_RadianToDegree,
      Func_AbsoluteValue,
      Func_LimitRealInRange,
      Func_Sign,
      Func_Cube,
      Func_Modulo,
      Func_TernInf,
      Func_TernSup,
      Func_TernEq,
      Func_TernInfEq,
      Func_TernSupEq,
      Func_TernOp,
      Func_TemporalRealCombination,
      Func_GetHitPoints,
      Func_AddAndGetHitPoints,
      Func_SubAndGetHitPoints,
      Func_GetHitPointsMax,
      Func_AddAndGetHitPointsMax,
      Func_SubAndGetHitPointsMax,
      Func_ListSize,
      Func_GivePersoInList,
      Func_AbsoluteVector,
      Func_RelativeVector,
      Func_VectorLocalToGlobal,
      Func_VectorGlobalToLocal,
      Func_GetScreenCoordinates,
      Func_GetScreenDSActif,
      Func_GetStyletCordinates,
      Func_MAGNETGetStrength,
      Func_MAGNETGetFar,
      Func_MAGNETGetNear,
      Func_MAGNETGetDuration,
      Func_SPO_GetDrawFlag,
      Func_GetTime,
      Func_ElapsedTime,
      Func_GetDT,
      Func_GetFrameLength,
      Func_GetInputAnalogicValue,
      Func_VitessePadAnalogique,
      Func_GenerateObject,
      Func_CountGeneratedObjects,
      Func_GetGlobalCounter,
      Func_GetSubMapId,
      Func_AddColor,
      Func_AddRed,
      Func_AddGreen,
      Func_AddBlue,
      Func_AddAlpha,
      Func_ColorRGBA,
      Func_ColorRGB,
      Func_ColorRed,
      Func_ColorGreen,
      Func_ColorBlue,
      Func_ColorAlpha,
      Func_GetVisualGMTColor,
      Func_GetVisualGMTSpecularCoef,
      Func_GetVisualGMTSpecularExponant,
      Func_GetVisualGMTDiffuseCoef,
      Func_GetVisualGMTAmbientCoef,
      Func_GetVisualGMTTextureScrollingCoefU,
      Func_GetVisualGMTTextureScrollingCoefV,
      Func_GetVisualGMTFrame,
      Func_GetVisualGMTNumberOfFrames,
      Func_SaveGame,
      Func_LoadGame,
      Func_EraseGame,
      Func_GetCurrentSlotNumber,
      Func_IsAValidSlotName,
      Func_RepairCorruption,
      Func_MICRO_GetSoufleValue,

      // Func1

      Func_VitesseHorizontaleDuPerso,
      Func_VitesseVerticaleDuPerso,
      Func_GetPersoZoomFactor,
      Func_GetPersoSighting,
      Func_GetPersoHorizon,
      Func_GetPersoBanking,
      Func_LitPositionZDM,
      Func_LitPositionZDE,
      Func_LitPositionZDD,
      Func_LitCentreZDM,
      Func_LitCentreZDE,
      Func_LitCentreZDD,
      Func_LitAxeZDM,
      Func_LitAxeZDE,
      Func_LitAxeZDD,
      Func_LitDimensionZDM,
      Func_LitDimensionZDE,
      Func_LitDimensionZDD,
      Func_VecteurPointAxe,
      Func_VecteurPointSegment,
      Func_VectorContribution,
      Func_VectorCombination,
      Func_TemporalVectorCombination,
      Func_ScaledVector,
      Func_GetVectorNorm,
      Func_RotateVector,
      Func_VecteurAngle,
      Func_VecteurCos,
      Func_VecteurSin,
      Func_GetNormalCollideVector,
      Func_GetNormalCollideVector2,
      Func_GetCollidePoint,
      Func_GetCollidePoint2,
      Func_GetHandsCollidePoint,
      eFunc_GetCollideRate,
      Func_GetCollideRate2,
      Func_GetCollideMaterialType,
      eFunc_GetCollideMaterialType2,
      Func_CollisionPoint,
      Func_CollisionNormalVector,
      Func_PersoCollisionne,
      Func_CollisionPointMaterial,
      Func_GetLastTraversedMaterialType,
      Func_GetLastTraversedMaterial,
      Func_GetCurrentCollidedGMT,
      Func_GetColliderType,
      Func_GetColliderVector,
      Func_GetColliderReal,
      Func_LitDernierPersoCollisione,
      Func_CalculVecteurRebond,
      Func_GetModuleAbsolutePosition,
      Func_GetModuleRelativePosition,
      Func_GetModuleZoomFactor,
      Func_GetModuleSighting,
      Func_CastIntegerToChannel,
      Func_GetSlotDate,
      Func_GetSlotName,
      Func_GetSlotScore,
      Func_GetStringCharAt,
      Func_GetFormattedTextInfo,
      Func_GetInputEntryName,
      Proc_GetMechanicGravityFactor,
      Proc_GetMechanicSlide,
      Proc_GetMechanicRebound,
      Proc_GetMechanicSlopeLimit,
      Proc_GetMechanicInertiaX,
      Proc_GetMechanicInertiaY,
      Proc_GetMechanicInertiaZ,
      Proc_GetMechanicTiltIntensity,
      Proc_GetMechanicTiltInertia,
      Proc_GetMechanicTiltOrigin,
      Proc_GetMechanicMaxSpeed,
      Proc_GetMechanicStreamPriority,
      Proc_GetMechanicStreamSpeed,
      Proc_GetMechanicStreamFactor,
      Proc_GetSlideFactorX,
      Proc_GetSlideFactorY,
      Proc_GetSlideFactorZ,
      Proc_JumpImpulsion,
      Proc_GetSpeedAnim,
      proc_HIERGetFather,
      Func_LitActivationZDD,
      Func_LitActivationZDM,
      Func_LitActivationZDE,
      Func_LitActivationZDR,
      Func_GetCollComputationFrequency,
      Func_GetBrainComputationFrequency,
      Func_GetLightComputationFrequency,
      Func_GetBooleanInArray,
      Func_GetNumberOfBooleanInArray,
      Func_GetButtonName,
      Func_GetDriversAvailable,
      Func_GetCurrentLanguageId,
      Func_GetNbLanguages,
      Func_GetLanguageText,
      Func_TextToInt,
      Func_GetMusicVolume,
      Func_GetSfxVolume,
      Func_SlotIsValid,
      Func_NbAvailableResolution,
      Func_CurrentResolution,
      Func_GetBrightness,
      Func_NameResolution,
      Func_GetNbSlotsAvailable,
      Func_GetTextureFiltering,
      Func_GetAntiAliasing,
      Func_GetSaturationDistance,
      Func_GetBackGroundDistance,
      Func_GetTooFarLimit,
      Func_GetTransparencyZoneMin,
      Func_GetTransparencyZoneMax,
      Func_ExecuteVariable,
      Func_ComputeProtectKey,
      Func_Xor,
      MATH_And,
      Func_Or,
      Func_Not,
      Func_DivU,
      Func_MulU,
      Func_AddU,
      Func_SubU,
      Func_MemoryValue,
      Func_GetCheats,
      Func_GetBacklight,
      Func_DoneAnalogCalibration,

      // FuncRay2

      Func_LitPointsDeMagie,
      Func_LitPointsDeMagieMax,
      Func_AjouteEtLitPointsDeMagie,
      Func_AjouteEtLitPointsDeMagieMax,
      Func_EnleveEtLitPointsDeMagie,
      Func_EnleveEtLitPointsDeMagieMax,
      Func_LitPointsDair,
      Func_LitPointsDairMax,
      Func_AjouteEtLitPointsDair,
      Func_AjouteEtLitPointsDairMax,
      Func_EnleveEtLitPointsDair,
      Func_EnleveEtLitPointsDairMax,
      Func_PersoLePlusProche,
      Func_NearestActorInCurrentSector,
      Func_NearerActorInFieldOfVision,
      Func_GetNbActivePerso,
      Func_CibleLaPlusProche,
      Func_CibleLaPlusProcheavecAngles,
      Func_ReseauWPnLePlusProche,
      Func_NetworkCloserWPOfType,
      Func_ReseauWPnLePlusDansLAxe,
      Func_ReseauWPnLePlusDansLAxe2,
      eFunc_NetworkNextWPWithCapa,
      Func_NetworkAffectTypeOfConnectedWP,
      Func_NetworkAffectTypeOfConnectedWP2,
      Func_ReseauCheminLePlusCourt,
      Func_NetworkBuildOrderedPath,
      Func_NetworkBuildOrderedPathCircular,
      Func_NetworkAllocateGraphToMSWay,
      Func_NetworkAllocateGraphToMSWayCircular,
      Func_ReseauLitIndexCourant,
      Func_ReseauForceIndexCourant,
      Func_ReseauLitPremierIndex,
      Func_ReseauLitDernierIndex,
      Func_ReseauIncrementIndex,
      Func_ReseauDecrementIndex,
      Func_ReseauLitWPAIndex,
      Func_ReseauLitCapaciteLiaisonAIndex,
      Func_ReseauChangeCapaciteLiaisonAIndex,
      Func_ReseauLitPoidsLiaisonAIndex,
      Func_ReseauChangePoidsLiaisonAIndex,
      Func_NetworkGetIndexOfWPInMSWay,
      Func_NetworkForceWPToCurrent,
      Func_ReseauTestExtremite,
      Func_ReseauLitCapaciteLiaisonDansGraph,
      Func_ReseauChangeCapaciteLiaisonDansGraph,
      Func_ReseauLitPoidsLiaisonDansGraph,
      Func_ReseauChangePoidsLiaisonDansGraph,
      Func_NetworkGetTypeOfWP,
      Func_CapsGetCapabilities,
      Func_CapabilityAtBitNumber,
      Func_GetScrollSpeed,
      Func_GetNbFrame,
      Func_GetFramecourante,
      Func_DotProduct,
      Func_CrossProduct,
      Func_Normalize,
      Func_GetSPOCoordinates,
      Func_ACTGetTractionFactor,
      Func_GetCenterZDEType,
      Func_GetCenterZDMType,
      Func_GetCenterZDRType,
      Func_GetCenterZDDType,
      Func_TextAffiche,
      Func_GetCPUCounter
   }
}