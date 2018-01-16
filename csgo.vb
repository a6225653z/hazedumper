' Tue, 16 Jan 2018 19:50:00 +0100

Namespace hazedumper
    Public Shared Class netvars
        Public Const m_ArmorValue as Integer = &HB238
        Public Const m_Collision as Integer = &H318
        Public Const m_CollisionGroup as Integer = &H470
        Public Const m_Local as Integer = &H2FAC
        Public Const m_MoveType as Integer = &H258
        Public Const m_OriginalOwnerXuidHigh as Integer = &H316C
        Public Const m_OriginalOwnerXuidLow as Integer = &H3168
        Public Const m_aimPunchAngle as Integer = &H301C
        Public Const m_aimPunchAngleVel as Integer = &H3028
        Public Const m_bGunGameImmunity as Integer = &H3894
        Public Const m_bHasDefuser as Integer = &HB248
        Public Const m_bHasHelmet as Integer = &HB22C
        Public Const m_bInReload as Integer = &H3245
        Public Const m_bIsDefusing as Integer = &H3888
        Public Const m_bIsScoped as Integer = &H387E
        Public Const m_bSpotted as Integer = &H939
        Public Const m_bSpottedByMask as Integer = &H97C
        Public Const m_dwBoneMatrix as Integer = &H2698
        Public Const m_fAccuracyPenalty as Integer = &H32B0
        Public Const m_fFlags as Integer = &H100
        Public Const m_flFallbackWear as Integer = &H3178
        Public Const m_flFlashDuration as Integer = &HA2F8
        Public Const m_flFlashMaxAlpha as Integer = &HA2F4
        Public Const m_flNextPrimaryAttack as Integer = &H31D8
        Public Const m_hActiveWeapon as Integer = &H2EE8
        Public Const m_hMyWeapons as Integer = &H2DE8
        Public Const m_hObserverTarget as Integer = &H3360
        Public Const m_hOwner as Integer = &H29BC
        Public Const m_hOwnerEntity as Integer = &H148
        Public Const m_iAccountID as Integer = &H2FA8
        Public Const m_iClip1 as Integer = &H3204
        Public Const m_iCompetitiveRanking as Integer = &H1A44
        Public Const m_iCompetitiveWins as Integer = &H1B48
        Public Const m_iCrosshairId as Integer = &HB2A4
        Public Const m_iEntityQuality as Integer = &H2F8C
        Public Const m_iFOVStart as Integer = &H31D8
        Public Const m_iGlowIndex as Integer = &HA310
        Public Const m_iHealth as Integer = &HFC
        Public Const m_iItemDefinitionIndex as Integer = &H2F88
        Public Const m_iItemIDHigh as Integer = &H2FA0
        Public Const m_iObserverMode as Integer = &H334C
        Public Const m_iShotsFired as Integer = &HA2B0
        Public Const m_iState as Integer = &H31F8
        Public Const m_iTeamNum as Integer = &HF0
        Public Const m_lifeState as Integer = &H25B
        Public Const m_nFallbackPaintKit as Integer = &H3170
        Public Const m_nFallbackSeed as Integer = &H3174
        Public Const m_nFallbackStatTrak as Integer = &H317C
        Public Const m_nForceBone as Integer = &H267C
        Public Const m_nTickBase as Integer = &H3404
        Public Const m_rgflCoordinateFrame as Integer = &H440
        Public Const m_szCustomName as Integer = &H301C
        Public Const m_szLastPlaceName as Integer = &H3588
        Public Const m_vecOrigin as Integer = &H134
        Public Const m_vecVelocity as Integer = &H110
        Public Const m_vecViewOffset as Integer = &H104
        Public Const m_viewPunchAngle as Integer = &H3010
    End Class
    Public Shared Class signatures
        Public Const dwClientState as Integer = &H57B7EC
        Public Const dwClientState_GetLocalPlayer as Integer = &H180
        Public Const dwClientState_IsHLTV as Integer = &H4CC8
        Public Const dwClientState_Map as Integer = &H28C
        Public Const dwClientState_MapDirectory as Integer = &H188
        Public Const dwClientState_MaxPlayer as Integer = &H310
        Public Const dwClientState_PlayerInfo as Integer = &H5240
        Public Const dwClientState_State as Integer = &H108
        Public Const dwClientState_ViewAngles as Integer = &H4D10
        Public Const dwEntityList as Integer = &H4A79EC4
        Public Const dwForceAttack as Integer = &H2EBC23C
        Public Const dwForceAttack2 as Integer = &H2EBC248
        Public Const dwForceBackward as Integer = &H2EBC2C0
        Public Const dwForceForward as Integer = &H2EBC2B4
        Public Const dwForceJump as Integer = &H4F11134
        Public Const dwForceLeft as Integer = &H2EBC29C
        Public Const dwForceRight as Integer = &H2EBC2A8
        Public Const dwGameDir as Integer = &H6190E8
        Public Const dwGameRulesProxy as Integer = &H4F7B47C
        Public Const dwGetAllClasses as Integer = &H4F7B54C
        Public Const dwGlobalVars as Integer = &H57B4F0
        Public Const dwGlowObjectManager as Integer = &H4F96D18
        Public Const dwInput as Integer = &H4EC4A88
        Public Const dwInterfaceLinkList as Integer = &H6DBD34
        Public Const dwLocalPlayer as Integer = &HA9D0DC
        Public Const dwMouseEnable as Integer = &HAA2940
        Public Const dwMouseEnablePtr as Integer = &HAA2910
        Public Const dwPlayerResource as Integer = &H2EBA5CC
        Public Const dwRadarBase as Integer = &H4EAEBBC
        Public Const dwSensitivity as Integer = &HAA27DC
        Public Const dwSensitivityPtr as Integer = &HAA27B0
        Public Const dwSetClanTag as Integer = &H869D0
        Public Const dwViewMatrix as Integer = &H4A6B934
        Public Const dwWeaponTable as Integer = &H4EC5684
        Public Const dwWeaponTableIndex as Integer = &H31FC
        Public Const dwYawPtr as Integer = &HAA25A0
        Public Const dwZoomSensitivityRatioPtr as Integer = &HAA7608
        Public Const dwbSendPackets as Integer = &HCCD9A
        Public Const dwppDirect3DDevice9 as Integer = &HA1F40
        Public Const m_pStudioHdr as Integer = &H293C
    End Class
End Namespace
