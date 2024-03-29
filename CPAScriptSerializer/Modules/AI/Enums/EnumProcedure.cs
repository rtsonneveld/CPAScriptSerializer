﻿using System;
using System.Collections.Generic;
using System.Text;
// ReSharper disable InconsistentNaming

namespace CPAScriptSerializer.Modules.AI.Enums {
   
   public enum EnumProcedure {

      Proc_SetHitPoints,
      Proc_SetHitPointsInit,
      Proc_SetHitPointsToInit,
      Proc_SetHitPointsToMax,
      Proc_AddHitPoints,
      Proc_SubHitPoints,
      Proc_SetHitPointsMax,
      Proc_SetHitPointsMaxToInit,
      Proc_SetHitPointsMaxToMax,
      Proc_AddHitPointsMax,
      Proc_SubHitPointsMax,
      Proc_TransparentDisplay,
      Proc_SetTransparency,
      Proc_ACT_SetDrawFlag,
      Proc_ModuleTransparentDisplay,
      Proc_ModuleTransparentDisplay2,
      Proc_SetModuleTransparency,
      Proc_SetModuleTransparency2,
      Proc_ListAffectWithPersoZDD,
      Proc_ListAffectWithModuleZDD,
      Proc_ListAffectWithPersoZDE,
      Proc_ListAffectWithModuleZDE,
      Proc_ListAffectWithPersoTypeZDE,
      Proc_ListAffectWithModuleTypeZDE,
      Proc_ListAffectTypeZDEWithTypeZDE,
      Proc_AddPersoInList,
      Proc_AddPersoInListAt,
      Proc_DeletePersoAtInList,
      Proc_FindPersoAndDeleteInList,
      Proc_Select,
      Proc_UnSelect,
      Proc_ListSort,
      Proc_ListSortByFamily,
      Proc_ListSortByModele,
      Proc_FillListWithAllPersoOfAFamily,
      Proc_FillListWithAllPersoOfAModel,
      Proc_DeleteFamilyInList,
      Proc_DeleteModelInList,
      Proc_ListUnion,
      Proc_ListInter,
      Proc_ListDiff,
      Proc_ListAdd,
      FOG_Proc_Activate,
      FOG_Proc_SetColor,
      FOG_Proc_SetNearFarInf,
      FOG_Proc_SetBlend,
      FOG_Proc_RestoreFog,
      FOG_Proc_SaveFog,
      Procedure_Magnet_ActiveMagnet,
      Procedure_Magnet_DeactiveMagnet,
      Procedure_Magnet_SetStrength,
      Procedure_Magnet_SetFar,
      Procedure_Magnet_SetNear,
      Procedure_Magnet_SetDuration,
      Proc_FootPath_AddFootPrint,
      Proc_FootPath_Clear,
      Proc_SinusEffect_SetFreq,
      Proc_SinusEffect_SetAmplitude,
      Proc_SinusEffect_SetState,
      Proc_SinusEffect_SetFreq3D,
      Proc_SinusEffect_SetRLIAmplitude,
      Proc_SinusEffect_SetRLIBase,
      Proc_SPO_SetDrawFlag,
      Proc_SPO_SetEngineDisplayModeFlag,
      Proc_DeactivateBut,
      Proc_ActivateBut,
      Proc_None,
      Proc_ChangeComport,
      Proc_ChangeComportReflex,
      Proc_ChangeMyComport,
      Proc_ChangeMyComportReflex,
      Proc_ChangeMyComportAndMyReflex,
      Proc_ChangeAction,
      Proc_ChangeActionForce,
      Proc_ChangeActionRandom,
      Proc_ChangeActionWithEvents,
      Proc_Loop,
      Proc_EndLoop,
      Proc_Break,
      Proc_PlayerIsDead,
      Proc_RestoreCardParameters,
      Proc_BreakAI,
      Proc_IgnoreTraceFlagForNextPicking,
      Proc_SetMainActor,
      Proc_ActivateObject,
      Proc_DesactivateObject,
      Proc_ChangeMap,
      Proc_ChangeMapNoAutosave,
      Proc_SetActionReturn,
      Proc_FactorAnimationFrameRate,
      Proc_SetCharacterPriority,
      Proc_ForcePersoHandling,
      Proc_PlayerIsDeadWithOption,
      Proc_ChangeMapAtPosition,
      Proc_PlayerIsDeadWithPlacement,
      Proc_SwapLinkTableObjects,
      Proc_ChangeCurrentObjectTable,
      Proc_BuildObjectTableFromTableAndString,
      Proc_BuildObjectTableFromFormattedString,
      Proc_StartSpeech,
      Proc_StopSpeech,
      Proc_TakeModuleControl,
      Proc_TakeManyModulesControl,
      Proc_ReleaseModuleControl,
      Proc_SaveGame,
      Proc_LoadGame,
      Proc_EraseGame,
      Proc_CopyGame,
      Proc_QuitGame,
      Proc_ActivateChannel,
      Proc_DeactivateChannel,
      Proc_PersoLightOn,
      Proc_PersoLightOff,
      Proc_SetPersoLightColor,
      Proc_SetPersoLightNearFar,
      Proc_SetPersoLightLittleBigAlpha,
      Proc_SetPersoLightGyrophare,
      Proc_SetPersoLightPulse,
      Proc_SetPersoLightParalleleType,
      Proc_SetPersoLightSphericalType,
      Proc_SetPersoLightHotSpotType,
      Proc_SetPersoLightAmbientType,
      Proc_SendSoundRequest,
      Proc_SendVoiceRequest,
      Proc_SendMusicRequest,
      Proc_SendAmbianceRequest,
      Proc_SendMenuSndRequest,
      Proc_DefautDisplay,
      Proc_DisplayVignette,
      Proc_DeleteVignette,
      Proc_SetParticleGeneratorOn,
      Proc_SetParticleGeneratorOff,
      Proc_SetParticleGenerator,
      Proc_SetGenerationModeNone,
      Proc_SetGenerationModeContinuous,
      Proc_SetGenerationModeCrenel,
      Proc_SetGenerationModeProbability,
      Proc_SetGenerationNbConstant,
      Proc_SetGenerationNbProbabilist,
      Proc_SetInfiniteLifeTime,
      Proc_SetConstantLifeTime,
      Proc_SetProbabilistLifeTime,
      Proc_Turn,
      Proc_Turn2,
      Proc_DeltaTurnPerso,
      Proc_TurnPerso,
      Proc_KillPerso,
      Proc_KillPersoAndClearVariable,
      Proc_SetVisualGMTColor,
      Proc_SetVisualGMTSpecularExponant,
      Proc_SetVisualGMTSpecularCoef,
      Proc_SetVisualGMTDiffuseCoef,
      Proc_SetVisualGMTAmbientCoef,
      Proc_SetVisualGMTAsChromed,
      Proc_SetVisualGMTTextureScrollingCoef,
      Proc_LockVisualGMT,
      Proc_UnlockVisualGMT,
      Proc_SetVisualGMTFrame,
      Func_SetScreenDSActif,
      Proc_SetAGO,
      Proc_ActivateMenuMap,
      Proc_JffTxt_Affiche,
      Proc_JffTxt_Extend,
      Proc_JffTxt_Modify,
      Proc_FadeIn,
      Proc_FadeOut,
      Proc_HUD_SetLumsCount,
      Proc_HUD_SetCagesCount,
      Proc_HUD_SetSwimGauge,
      Proc_HUD_SetHealthGauge,
      Proc_HUD_SetEnemyHealthGauge,
      Proc_DoCheatMenu,
      Proc_SetBacklight,
      Proc_BeginAnalogCalibration,
      Proc_EndAnalogCalibration,

#region Proc1

      Proc_OptionChangeDetailsValue,
      Proc_OptionChangeMusicVolume,
      Proc_OptionChangeSfxVolume,
      Proc_OptionChangeVoiceVolume,
      Proc_OptionChangeActionKey,
      Proc_ConfigureKey,
      Proc_SetPersoAbsolutePosition,
      Proc_SetPersoAtModulePosition,
      Proc_ForcePersoAveragePosition,
      Proc_RelativeMovePerso,
      Proc_ChangePersoAnySighting,
      Proc_ChangePersoSightingWithOffset,
      Proc_RotatePersoAroundX,
      Proc_RotatePersoAroundY,
      Proc_RotatePersoAroundZ,
      Proc_RotatePersoAroundVector,
      Proc_RotatePersoAroundVectorWithOffset,
      Proc_RotatePersoAroundXwithOffset,
      Proc_RotatePersoAroundYwithOffset,
      Proc_RotatePersoAroundZwithOffset,
      Proc_SetFullPersoOrientation,
      Proc_SetFullPersoOrientationWithOffset,
      Proc_ZoomPerso,
      Proc_ChangeOneCustomBit,
      Proc_ChangeManyCustomBits,
      Proc_ImposeSpeed,
      Proc_ImposeSpeedX,
      Proc_ImposeSpeedY,
      Proc_ImposeSpeedZ,
      Proc_ImposeSpeedXY,
      Proc_ImposeSpeedXYZ,
      Proc_ImposeAbsoluteSpeed,
      Proc_ImposeAbsoluteSpeedX,
      Proc_ImposeAbsoluteSpeedY,
      Proc_ImposeAbsoluteSpeedZ,
      Proc_ImposeAbsoluteSpeedXY,
      Proc_ImposeAbsoluteSpeedXYZ,
      Proc_ProposeSpeed,
      Proc_ProposeSpeedX,
      Proc_ProposeSpeedY,
      Proc_ProposeSpeedZ,
      Proc_ProposeSpeedXY,
      Proc_ProposeSpeedXYZ,
      Proc_ProposeAbsoluteSpeed,
      Proc_ProposeAbsoluteSpeedX,
      Proc_ProposeAbsoluteSpeedY,
      Proc_ProposeAbsoluteSpeedZ,
      Proc_ProposeAbsoluteSpeedXY,
      Proc_ProposeAbsoluteSpeedXYZ,
      Proc_FixePositionPerso,
      Proc_AddSpeed,
      Proc_AddSpeedX,
      Proc_AddSpeedY,
      Proc_AddSpeedZ,
      Proc_AddSpeedXY,
      Proc_AddSpeedXYZ,
      Proc_AddAbsoluteSpeed,
      Proc_AddAbsoluteSpeedX,
      Proc_AddAbsoluteSpeedY,
      Proc_AddAbsoluteSpeedZ,
      Proc_AddAbsoluteSpeedXY,
      Proc_AddAbsoluteSpeedXYZ,
      Proc_PrepareMorph,
      Proc_StopMorph,
      Proc_Morphing,
      Proc_ReleaseAllModulesControl,
      Proc_ChangeModuleSighting,
      Proc_SetModuleAbsolutePosition,
      Proc_RelativeMoveModule,
      Proc_ChangeModuleSightingWithOffset,
      Proc_RotateModuleAroundX,
      Proc_RotateModuleAroundY,
      Proc_RotateModuleAroundZ,
      Proc_RotateModuleAroundVector,
      Proc_RotateModuleAroundVectorOffset,
      Proc_RotateModuleAroundXwithOffset,
      Proc_RotateModuleAroundYwithOffset,
      Proc_RotateModuleAroundZwithOffset,
      Proc_SetFullModuleOrientation,
      Proc_SetFullModuleOrientationOffset,
      Proc_ZoomModule,
      Proc_SetColliderType,
      Proc_SetColliderVector,
      Proc_SetColliderReal,
      Proc_ResetLastCollisionActor,
      Proc_ClearCollisionReport,
      Proc_SetGoThroughMechanicsHandling,
      Proc_EraseLastGoThroughMaterial,
      Proc_StringAddChar,
      Proc_StringReplaceChar,
      Proc_StringRemoveChar,
      Proc_ChangeLanguage,
      Proc_IntToText,
      Proc_SetMechanicAnimation,
      Proc_SetMechanicCollide,
      Proc_SetMechanicGravity,
      Proc_SetMechanicTilt,
      Proc_SetMechanicGI,
      Proc_SetMechanicClimb,
      Proc_SetMechanicOnGround,
      Proc_SetMechanicSpider,
      Proc_SetMechanicShoot,
      Proc_SetMechanicSwim,
      Proc_SetMechanicNeverFall,
      Proc_ResetMechanicNewMechanic,
      Proc_SetMechanicCollisionControl,
      Proc_SetMechanicKeepSpeedZ,
      Proc_SetMechanicSpeedLimit,
      Proc_SetMechanicInertia,
      Proc_SetMechanicStream,
      Proc_SetMechanicStickOnPlatform,
      Proc_SetMechanicScale,
      Proc_SetMechanicGravityFactor,
      Proc_SetMechanicSlide,
      Proc_SetMechanicMaxRebound,
      Proc_SetMechanicSlopeLimit,
      Proc_SetMechanicInertiaX,
      Proc_SetMechanicInertiaY,
      Proc_SetMechanicInertiaZ,
      Proc_SetMechanicInertiaXYZ,
      Proc_SetMechanicTiltIntensity,
      Proc_SetMechanicTiltInertia,
      Proc_SetMechanicTiltOrigin,
      Proc_SetMechanicSpeedMax,
      Proc_SetMechanicStreamPriority,
      Proc_SetMechanicStreamSpeed,
      Proc_SetMechanicStreamFactor,
      Proc_AddMechanicStreamSpeed,
      Proc_AddMechanicStreamSpeedList,
      Proc_MoveLimit,
      Proc_MoveLimitX,
      Proc_MoveLimitY,
      Proc_MoveLimitZ,
      Proc_MoveLimitXYZ,
      Proc_StopMoveLimitX,
      Proc_StopMoveLimitY,
      Proc_StopMoveLimitZ,
      Proc_StopMoveLimitXYZ,
      Proc_SetPlatformLink,
      Proc_FreePlatformLink,
      Proc_SetScale,
      Proc_SetSlideFactorXYZ,
      Proc_SetSlideFactorX,
      Proc_SetSlideFactorY,
      Proc_SetSlideFactorZ,
      Proc_SetClimbSpeedLimit,
      Proc_SetHangingLimit,
      Proc_SetHangingOff,
      Proc_SetBaseCoeff,
      Proc_SetWalkCoeff,
      Proc_HierSetFather,
      Proc_HierFreeFather,
      Proc_HierListOfSon,
      Proc_HierSetPlatformType,
      Proc_HierLinkControl,
      Proc_HierFreezeEngine,
      Proc_FixePositionZDM,
      Proc_FixePositionZDD,
      Proc_FixePositionZDE,
      Proc_ChangeLightIntensity,
      Proc_SPO_ChangeFlag,
      ACT_ChangeSpoFlag,
      Proc_EcranChangeTaille,
      Proc_EcranChangeClip,
      Proc_EcranChangePos,
      Proc_EcranChangePosPercent,
      Proc_EcranChangeRatio,
      Proc_OMBREAffichage,
      Proc_OMBREChangeHauteur,
      Proc_OMBREChangeVecteurProjection,
      Proc_ForceActivationZDD,
      Proc_ForceActivationZDM,
      Proc_ForceActivationZDE,
      Proc_ForceActivationZDR,
      Proc_ForceDesactivationZDD,
      Proc_ForceDesactivationZDM,
      Proc_ForceDesactivationZDE,
      Proc_ForceDesactivationZDR,
      Proc_LibereActivationZDD,
      Proc_LibereActivationZDM,
      Proc_LibereActivationZDE,
      Proc_LibereActivationZDR,
      Proc_ActiveZDR,
      Proc_SetNoColWithMap,
      Proc_SetNoColWithProjectile,
      Proc_SetNoColWithSeconfCharact,
      Proc_SetNoColWithMainCharact,
      Proc_SetNoColWithOtherSectors,
      Proc_SetNoColZdeWithProjectile,
      Proc_SetCollComputeFreq,
      Proc_SetBrainComputeFreq,
      Proc_SetLightComputeFreq,
      Proc_SetUsedExitIdentifier,
      Proc_GetUsedExitIdentifier,
      eProc_SetGlobalCounter,
      PAD_ReadAnalogJoystickMarioMode,
      PAD_InitAnalogJoystickAxes,
      Proc_SetPadReadingDsgvars,
      Proc_CancelKeyboardInertia,
      Proc_GetPadCalibration,
      Proc_SetPadCalibration,
      ACT_SetBooleanInArray,
      TEXT_SetDefaultFormatCharacter,
      VID_SelectDriver,
      Proc_SelectShapnessMax,
      Proc_CenterScreen,
      VID_SelectResolution,
      VID_ChangeBrightness,
      TEXT_IntegerParameter,
      TEXT_RealParameter,
      VID_SetTextureFiltering,
      VID_SetAntiAliasing,
      SOUND_SetInStereoMode,
      Proc_SetSaturationBackGroundDistance,
      Proc_SaveCurrentRequest,
      Proc_RestoreRequest,
      Proc_DrawSegment,
      Proc_UpdateChecksum,
      Proc_ShellExecute,
      Proc_ForceVerticalUsingX,
      Proc_ForceVerticalUsingY,

#endregion

#region ProcRay2
      Proc_FixePointsDeMagie,
      Proc_FixePointsDeMagieMax,
      Proc_InitPointsDeMagie,
      Proc_InitPointsDeMagieMax,
      Proc_AddMagicPoints,
      Proc_AddMagicPointsMax,
      Proc_SubMagicPoints,
      Proc_SubMagicPointsMax,
      Proc_FixePointsDair,
      Proc_FixePointsDairMax,
      Proc_InitPointsDair,
      Proc_InitPointsDairMax,
      Proc_AddAirPoints,
      Proc_AddAirPointsMax,
      Proc_SubAirPoints,
      Proc_SubAirPointsMax,
      Proc_FixePositionFade,
      Proc_SetLocalPersoLight,
      Proc_SetStaticLightOnOff,
      Proc_SetStaticLightNearFar,
      Proc_SetStaticLightColor,
      Proc_ComputeLightEffect,
      Proc_RLIPasDeRLI,
      Proc_RLIFixe,
      Proc_RLIBlend,
      Proc_ChangeTypeOfWP,
      Proc_CAPSSetCapabilities,
      Proc_CAPSAddCapabilities,
      Proc_CAPSSubCapabilities,
      Proc_CAPSChangeCapabilities,
      Proc_ReinitGraph,
      Proc_SetScrollSpeed,
      Proc_SetScrollOnOff,
      Proc_SetTextureOffset,
      Proc_SetScrollPause,
      Proc_ChangeCurrFrame,
      Proc_ChangeRandomFrame,
      Proc_FreezeAnim,
      Proc_UnFreezeAnim,
      Proc_SetSuperimposed,
      Proc_SetSuperimposed2,
      Proc_ReleaseSuperimposed,
      Proc_SetCoordinates,
      Proc_SwitchSuperimposedTab,
      Proc_ACTsetTractionFactor,
      Proc_TurnToPositionAngle,
      Proc_TurnToPositionSpeed,
      Proc_TABSortArray,
      Proc_ActiveJoystickAnal,
      Proc_UnActiveJoystickAnal,
      Proc_SetZDMSizeSphere,
      Proc_SetZDDSizeCone,
      Proc_SetVolumeAnim,
      Proc_SetVolumeMusic,
      Proc_SetVolumeAmbiance,
      Proc_SetDopplerEffect,
      Proc_PauseSound,
      Proc_ResumeSound,
      Proc_StopMenuSound,
      Proc_ChangeCaractere,
      Proc_FormateTexte,
      Proc_ValideNomDuSlot,
      Proc_RestoreNomDuSlot,
      Proc_ChangePersoSighting,
      Proc_PlayDemo,
      PAD_InitKeyBoardDirections,
      PAD_SetCenterPosition,
      PAD_SetMaximalValues,
      Proc_ChangeTooFarLimit,
      Proc_ChangeTransparencyZone,
      Proc_SetBaseFrequenceForMenu,
      Proc_SaveSinusContext,
      Proc_RestoreSinusContext,
      Func_TextSuperImposed,
      #endregion

#region ProcCam
      Proc_Cam_UpdatePosition,
      Proc_Cam_ChangeShiftTarget,
      Proc_Cam_ChangeShiftPos,
      Proc_Cam_ChangeDistMin,
      Proc_Cam_ChangeDistMax,
      Proc_Cam_ChangeBoundDistMin,
      Proc_Cam_ChangeBoundDistMax,
      Proc_Cam_ChangeAngleAlpha,
      Proc_Cam_ChangeAngleShiftAlpha,
      Proc_Cam_ChangeAngleTheta,
      Proc_Cam_ChangeAngleShiftTheta,
      Proc_Cam_ChangeLinearSpeed,
      Proc_Cam_ChangeLinearIncreaseSpeed,
      Proc_Cam_ChangeLinearDecreaseSpeed,
      Proc_Cam_ChangeAngularSpeed,
      Proc_Cam_ChangeAngularIncreaseSpeed,
      Proc_Cam_ChangeAngularDecreaseSpeed,
      Proc_Cam_ChangeTargetSpeed,
      Proc_Cam_ChangeTargetIncreaseSpeed,
      Proc_Cam_ChangeTargetDecreaseSpeed,
      Proc_Cam_ChangeFocal,
      Proc_Cam_ChangeZMin,
      Proc_Cam_ChangeZMax,
      Proc_Cam_ChangeTgtPerso,
      Proc_Cam_ChangeSecondTgtPerso,
      Proc_Cam_ChangeChannel,
      Proc_Cam_Activate,
      Proc_Cam_AssociateViewport,
      Proc_Cam_ResetIAFlags,
      Proc_Cam_SetFlagNoDynamicTarget,
      Proc_Cam_SetFlagNoAverageMoveTgtPerso,
      Proc_Cam_SetFlagNoParseCutAngle,
      Proc_Cam_SetFlagNoVisibility,
      Proc_Cam_SetFlagNoVisibilityWithDynHie,
      Proc_Cam_SetFlagNoDynChangeTheta,
      Proc_Cam_SetFlagNoShiftUntilPosReached,
      Proc_Cam_SetFlagNoDynSpeed,
      Proc_Cam_ResetDNMFlags,
      Proc_Cam_SetFlagNoLinearParsing,
      Proc_Cam_SetFlagNoLinearInertia,
      Proc_Cam_SetFlagNoAngularParsing,
      Proc_Cam_SetFlagNoAngularInertia,
      Proc_Cam_SetFlagNoTargetParsing,
      Proc_Cam_SetFlagNoTargetInertia,
      Proc_Cam_SetFlagFixedOrientation,
      Proc_Cam_SetFlagNoObstacle,
      Proc_Cam_SetFlagNoCollisionWhenNotMoving,
      Proc_Cam_ChangeConstants,
      Proc_Cam_SaveConstants,
      Proc_Cam_RestoreConstants,
      Proc_Cam_ShowInfo,
      Proc_Cam_ForceTarget,
      Proc_Cam_ForcePosition,
      Proc_Cam_ForceRefAxis,
      Proc_Cam_Reset,
      Proc_Cam_ForceBestPos,
      Proc_Cam_ForceNormalState,
      Proc_Cam_ForceMovingOnRail,
      Proc_Cam_SetCameraModeForEngine,
      #endregion

      #region DONALD (not present in R4DS)

      Proc_SetLensFlare, // Found in RAC_LensFlare.rul
      Proc_FixePositionMirror, // Found in RAC_Mirroir.rul
      Proc_FullWhite,

      #endregion

   }
}
