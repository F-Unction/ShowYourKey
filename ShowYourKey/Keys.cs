using System;
using System.ComponentModel;
using System.Drawing.Design;

namespace ShowYourKey
{
	/// <summary>Specifies key codes and modifiers.</summary>
	// Token: 0x020001AE RID: 430
	[Flags]
	[TypeConverter(typeof(KeysConverter))]
	public enum Keys
	{
		/// <summary>The bitmask to extract a key code from a key value.</summary>
		// Token: 0x04000365 RID: 869
		KeyCode = 65535,
		/// <summary>The bitmask to extract modifiers from a key value.</summary>
		// Token: 0x04000366 RID: 870
		Modifiers = -65536,
		/// <summary>No key pressed.</summary>
		// Token: 0x04000367 RID: 871
		None = 0,
		/// <summary>The left mouse button.</summary>
		// Token: 0x04000368 RID: 872
		LButton = 1,
		/// <summary>The right mouse button.</summary>
		// Token: 0x04000369 RID: 873
		RButton = 2,
		/// <summary>The CANCEL key.</summary>
		// Token: 0x0400036A RID: 874
		Cancel = 3,
		/// <summary>The middle mouse button (three-button mouse).</summary>
		// Token: 0x0400036B RID: 875
		MButton = 4,
		/// <summary>The first x mouse button (five-button mouse).</summary>
		// Token: 0x0400036C RID: 876
		XButton1 = 5,
		/// <summary>The second x mouse button (five-button mouse).</summary>
		// Token: 0x0400036D RID: 877
		XButton2 = 6,
		/// <summary>The BACKSPACE key.</summary>
		// Token: 0x0400036E RID: 878
		Back = 8,
		/// <summary>The TAB key.</summary>
		// Token: 0x0400036F RID: 879
		Tab = 9,
		/// <summary>The LINEFEED key.</summary>
		// Token: 0x04000370 RID: 880
		LineFeed = 10,
		/// <summary>The CLEAR key.</summary>
		// Token: 0x04000371 RID: 881
		Clear = 12,
		/// <summary>The RETURN key.</summary>
		// Token: 0x04000372 RID: 882
		Return = 13,
		/// <summary>The ENTER key.</summary>
		// Token: 0x04000373 RID: 883
		Enter = 13,
		/// <summary>The SHIFT key.</summary>
		// Token: 0x04000374 RID: 884
		ShiftKey = 16,
		/// <summary>The CTRL key.</summary>
		// Token: 0x04000375 RID: 885
		ControlKey = 17,
		/// <summary>The ALT key.</summary>
		// Token: 0x04000376 RID: 886
		Menu = 18,
		/// <summary>The PAUSE key.</summary>
		// Token: 0x04000377 RID: 887
		Pause = 19,
		/// <summary>The CAPS LOCK key.</summary>
		// Token: 0x04000378 RID: 888
		Capital = 20,
		/// <summary>The CAPS LOCK key.</summary>
		// Token: 0x04000379 RID: 889
		CapsLock = 20,
		/// <summary>The IME Kana mode key.</summary>
		// Token: 0x0400037A RID: 890
		KanaMode = 21,
		/// <summary>The IME Hanguel mode key. (maintained for compatibility; use <see langword="HangulMode" />)</summary>
		// Token: 0x0400037B RID: 891
		HanguelMode = 21,
		/// <summary>The IME Hangul mode key.</summary>
		// Token: 0x0400037C RID: 892
		HangulMode = 21,
		/// <summary>The IME Junja mode key.</summary>
		// Token: 0x0400037D RID: 893
		JunjaMode = 23,
		/// <summary>The IME final mode key.</summary>
		// Token: 0x0400037E RID: 894
		FinalMode = 24,
		/// <summary>The IME Hanja mode key.</summary>
		// Token: 0x0400037F RID: 895
		HanjaMode = 25,
		/// <summary>The IME Kanji mode key.</summary>
		// Token: 0x04000380 RID: 896
		KanjiMode = 25,
		/// <summary>The ESC key.</summary>
		// Token: 0x04000381 RID: 897
		Escape = 27,
		/// <summary>The IME convert key.</summary>
		// Token: 0x04000382 RID: 898
		IMEConvert = 28,
		/// <summary>The IME nonconvert key.</summary>
		// Token: 0x04000383 RID: 899
		IMENonconvert = 29,
		/// <summary>The IME accept key, replaces <see cref="F:System.Windows.Forms.Keys.IMEAceept" />.</summary>
		// Token: 0x04000384 RID: 900
		IMEAccept = 30,
		/// <summary>The IME accept key. Obsolete, use <see cref="F:System.Windows.Forms.Keys.IMEAccept" /> instead.</summary>
		// Token: 0x04000385 RID: 901
		IMEAceept = 30,
		/// <summary>The IME mode change key.</summary>
		// Token: 0x04000386 RID: 902
		IMEModeChange = 31,
		/// <summary>The SPACEBAR key.</summary>
		// Token: 0x04000387 RID: 903
		Space = 32,
		/// <summary>The PAGE UP key.</summary>
		// Token: 0x04000388 RID: 904
		Prior = 33,
		/// <summary>The PAGE UP key.</summary>
		// Token: 0x04000389 RID: 905
		PageUp = 33,
		/// <summary>The PAGE DOWN key.</summary>
		// Token: 0x0400038A RID: 906
		Next = 34,
		/// <summary>The PAGE DOWN key.</summary>
		// Token: 0x0400038B RID: 907
		PageDown = 34,
		/// <summary>The END key.</summary>
		// Token: 0x0400038C RID: 908
		End = 35,
		/// <summary>The HOME key.</summary>
		// Token: 0x0400038D RID: 909
		Home = 36,
		/// <summary>The LEFT ARROW key.</summary>
		// Token: 0x0400038E RID: 910
		Left = 37,
		/// <summary>The UP ARROW key.</summary>
		// Token: 0x0400038F RID: 911
		Up = 38,
		/// <summary>The RIGHT ARROW key.</summary>
		// Token: 0x04000390 RID: 912
		Right = 39,
		/// <summary>The DOWN ARROW key.</summary>
		// Token: 0x04000391 RID: 913
		Down = 40,
		/// <summary>The SELECT key.</summary>
		// Token: 0x04000392 RID: 914
		Select = 41,
		/// <summary>The PRINT key.</summary>
		// Token: 0x04000393 RID: 915
		Print = 42,
		/// <summary>The EXECUTE key.</summary>
		// Token: 0x04000394 RID: 916
		Execute = 43,
		/// <summary>The PRINT SCREEN key.</summary>
		// Token: 0x04000395 RID: 917
		Snapshot = 44,
		/// <summary>The PRINT SCREEN key.</summary>
		// Token: 0x04000396 RID: 918
		PrintScreen = 44,
		/// <summary>The INS key.</summary>
		// Token: 0x04000397 RID: 919
		Insert = 45,
		/// <summary>The DEL key.</summary>
		// Token: 0x04000398 RID: 920
		Delete = 46,
		/// <summary>The HELP key.</summary>
		// Token: 0x04000399 RID: 921
		Help = 47,
		/// <summary>The 0 key.</summary>
		// Token: 0x0400039A RID: 922
		D0 = 48,
		/// <summary>The 1 key.</summary>
		// Token: 0x0400039B RID: 923
		D1 = 49,
		/// <summary>The 2 key.</summary>
		// Token: 0x0400039C RID: 924
		D2 = 50,
		/// <summary>The 3 key.</summary>
		// Token: 0x0400039D RID: 925
		D3 = 51,
		/// <summary>The 4 key.</summary>
		// Token: 0x0400039E RID: 926
		D4 = 52,
		/// <summary>The 5 key.</summary>
		// Token: 0x0400039F RID: 927
		D5 = 53,
		/// <summary>The 6 key.</summary>
		// Token: 0x040003A0 RID: 928
		D6 = 54,
		/// <summary>The 7 key.</summary>
		// Token: 0x040003A1 RID: 929
		D7 = 55,
		/// <summary>The 8 key.</summary>
		// Token: 0x040003A2 RID: 930
		D8 = 56,
		/// <summary>The 9 key.</summary>
		// Token: 0x040003A3 RID: 931
		D9 = 57,
		/// <summary>The A key.</summary>
		// Token: 0x040003A4 RID: 932
		A = 65,
		/// <summary>The B key.</summary>
		// Token: 0x040003A5 RID: 933
		B = 66,
		/// <summary>The C key.</summary>
		// Token: 0x040003A6 RID: 934
		C = 67,
		/// <summary>The D key.</summary>
		// Token: 0x040003A7 RID: 935
		D = 68,
		/// <summary>The E key.</summary>
		// Token: 0x040003A8 RID: 936
		E = 69,
		/// <summary>The F key.</summary>
		// Token: 0x040003A9 RID: 937
		F = 70,
		/// <summary>The G key.</summary>
		// Token: 0x040003AA RID: 938
		G = 71,
		/// <summary>The H key.</summary>
		// Token: 0x040003AB RID: 939
		H = 72,
		/// <summary>The I key.</summary>
		// Token: 0x040003AC RID: 940
		I = 73,
		/// <summary>The J key.</summary>
		// Token: 0x040003AD RID: 941
		J = 74,
		/// <summary>The K key.</summary>
		// Token: 0x040003AE RID: 942
		K = 75,
		/// <summary>The L key.</summary>
		// Token: 0x040003AF RID: 943
		L = 76,
		/// <summary>The M key.</summary>
		// Token: 0x040003B0 RID: 944
		M = 77,
		/// <summary>The N key.</summary>
		// Token: 0x040003B1 RID: 945
		N = 78,
		/// <summary>The O key.</summary>
		// Token: 0x040003B2 RID: 946
		O = 79,
		/// <summary>The P key.</summary>
		// Token: 0x040003B3 RID: 947
		P = 80,
		/// <summary>The Q key.</summary>
		// Token: 0x040003B4 RID: 948
		Q = 81,
		/// <summary>The R key.</summary>
		// Token: 0x040003B5 RID: 949
		R = 82,
		/// <summary>The S key.</summary>
		// Token: 0x040003B6 RID: 950
		S = 83,
		/// <summary>The T key.</summary>
		// Token: 0x040003B7 RID: 951
		T = 84,
		/// <summary>The U key.</summary>
		// Token: 0x040003B8 RID: 952
		U = 85,
		/// <summary>The V key.</summary>
		// Token: 0x040003B9 RID: 953
		V = 86,
		/// <summary>The W key.</summary>
		// Token: 0x040003BA RID: 954
		W = 87,
		/// <summary>The X key.</summary>
		// Token: 0x040003BB RID: 955
		X = 88,
		/// <summary>The Y key.</summary>
		// Token: 0x040003BC RID: 956
		Y = 89,
		/// <summary>The Z key.</summary>
		// Token: 0x040003BD RID: 957
		Z = 90,
		/// <summary>The left Windows logo key (Microsoft Natural Keyboard).</summary>
		// Token: 0x040003BE RID: 958
		LWin = 91,
		/// <summary>The right Windows logo key (Microsoft Natural Keyboard).</summary>
		// Token: 0x040003BF RID: 959
		RWin = 92,
		/// <summary>The application key (Microsoft Natural Keyboard).</summary>
		// Token: 0x040003C0 RID: 960
		Apps = 93,
		/// <summary>The computer sleep key.</summary>
		// Token: 0x040003C1 RID: 961
		Sleep = 95,
		/// <summary>The 0 key on the numeric keypad.</summary>
		// Token: 0x040003C2 RID: 962
		NumPad0 = 96,
		/// <summary>The 1 key on the numeric keypad.</summary>
		// Token: 0x040003C3 RID: 963
		NumPad1 = 97,
		/// <summary>The 2 key on the numeric keypad.</summary>
		// Token: 0x040003C4 RID: 964
		NumPad2 = 98,
		/// <summary>The 3 key on the numeric keypad.</summary>
		// Token: 0x040003C5 RID: 965
		NumPad3 = 99,
		/// <summary>The 4 key on the numeric keypad.</summary>
		// Token: 0x040003C6 RID: 966
		NumPad4 = 100,
		/// <summary>The 5 key on the numeric keypad.</summary>
		// Token: 0x040003C7 RID: 967
		NumPad5 = 101,
		/// <summary>The 6 key on the numeric keypad.</summary>
		// Token: 0x040003C8 RID: 968
		NumPad6 = 102,
		/// <summary>The 7 key on the numeric keypad.</summary>
		// Token: 0x040003C9 RID: 969
		NumPad7 = 103,
		/// <summary>The 8 key on the numeric keypad.</summary>
		// Token: 0x040003CA RID: 970
		NumPad8 = 104,
		/// <summary>The 9 key on the numeric keypad.</summary>
		// Token: 0x040003CB RID: 971
		NumPad9 = 105,
		/// <summary>The multiply key.</summary>
		// Token: 0x040003CC RID: 972
		Multiply = 106,
		/// <summary>The add key.</summary>
		// Token: 0x040003CD RID: 973
		Add = 107,
		/// <summary>The separator key.</summary>
		// Token: 0x040003CE RID: 974
		Separator = 108,
		/// <summary>The subtract key.</summary>
		// Token: 0x040003CF RID: 975
		Subtract = 109,
		/// <summary>The decimal key.</summary>
		// Token: 0x040003D0 RID: 976
		Decimal = 110,
		/// <summary>The divide key.</summary>
		// Token: 0x040003D1 RID: 977
		Divide = 111,
		/// <summary>The F1 key.</summary>
		// Token: 0x040003D2 RID: 978
		F1 = 112,
		/// <summary>The F2 key.</summary>
		// Token: 0x040003D3 RID: 979
		F2 = 113,
		/// <summary>The F3 key.</summary>
		// Token: 0x040003D4 RID: 980
		F3 = 114,
		/// <summary>The F4 key.</summary>
		// Token: 0x040003D5 RID: 981
		F4 = 115,
		/// <summary>The F5 key.</summary>
		// Token: 0x040003D6 RID: 982
		F5 = 116,
		/// <summary>The F6 key.</summary>
		// Token: 0x040003D7 RID: 983
		F6 = 117,
		/// <summary>The F7 key.</summary>
		// Token: 0x040003D8 RID: 984
		F7 = 118,
		/// <summary>The F8 key.</summary>
		// Token: 0x040003D9 RID: 985
		F8 = 119,
		/// <summary>The F9 key.</summary>
		// Token: 0x040003DA RID: 986
		F9 = 120,
		/// <summary>The F10 key.</summary>
		// Token: 0x040003DB RID: 987
		F10 = 121,
		/// <summary>The F11 key.</summary>
		// Token: 0x040003DC RID: 988
		F11 = 122,
		/// <summary>The F12 key.</summary>
		// Token: 0x040003DD RID: 989
		F12 = 123,
		/// <summary>The F13 key.</summary>
		// Token: 0x040003DE RID: 990
		F13 = 124,
		/// <summary>The F14 key.</summary>
		// Token: 0x040003DF RID: 991
		F14 = 125,
		/// <summary>The F15 key.</summary>
		// Token: 0x040003E0 RID: 992
		F15 = 126,
		/// <summary>The F16 key.</summary>
		// Token: 0x040003E1 RID: 993
		F16 = 127,
		/// <summary>The F17 key.</summary>
		// Token: 0x040003E2 RID: 994
		F17 = 128,
		/// <summary>The F18 key.</summary>
		// Token: 0x040003E3 RID: 995
		F18 = 129,
		/// <summary>The F19 key.</summary>
		// Token: 0x040003E4 RID: 996
		F19 = 130,
		/// <summary>The F20 key.</summary>
		// Token: 0x040003E5 RID: 997
		F20 = 131,
		/// <summary>The F21 key.</summary>
		// Token: 0x040003E6 RID: 998
		F21 = 132,
		/// <summary>The F22 key.</summary>
		// Token: 0x040003E7 RID: 999
		F22 = 133,
		/// <summary>The F23 key.</summary>
		// Token: 0x040003E8 RID: 1000
		F23 = 134,
		/// <summary>The F24 key.</summary>
		// Token: 0x040003E9 RID: 1001
		F24 = 135,
		/// <summary>The NUM LOCK key.</summary>
		// Token: 0x040003EA RID: 1002
		NumLock = 144,
		/// <summary>The SCROLL LOCK key.</summary>
		// Token: 0x040003EB RID: 1003
		Scroll = 145,
		/// <summary>The left SHIFT key.</summary>
		// Token: 0x040003EC RID: 1004
		LShiftKey = 160,
		/// <summary>The right SHIFT key.</summary>
		// Token: 0x040003ED RID: 1005
		RShiftKey = 161,
		/// <summary>The left CTRL key.</summary>
		// Token: 0x040003EE RID: 1006
		LControlKey = 162,
		/// <summary>The right CTRL key.</summary>
		// Token: 0x040003EF RID: 1007
		RControlKey = 163,
		/// <summary>The left ALT key.</summary>
		// Token: 0x040003F0 RID: 1008
		LMenu = 164,
		/// <summary>The right ALT key.</summary>
		// Token: 0x040003F1 RID: 1009
		RMenu = 165,
		/// <summary>The browser back key.</summary>
		// Token: 0x040003F2 RID: 1010
		BrowserBack = 166,
		/// <summary>The browser forward key.</summary>
		// Token: 0x040003F3 RID: 1011
		BrowserForward = 167,
		/// <summary>The browser refresh key.</summary>
		// Token: 0x040003F4 RID: 1012
		BrowserRefresh = 168,
		/// <summary>The browser stop key.</summary>
		// Token: 0x040003F5 RID: 1013
		BrowserStop = 169,
		/// <summary>The browser search key.</summary>
		// Token: 0x040003F6 RID: 1014
		BrowserSearch = 170,
		/// <summary>The browser favorites key.</summary>
		// Token: 0x040003F7 RID: 1015
		BrowserFavorites = 171,
		/// <summary>The browser home key.</summary>
		// Token: 0x040003F8 RID: 1016
		BrowserHome = 172,
		/// <summary>The volume mute key.</summary>
		// Token: 0x040003F9 RID: 1017
		VolumeMute = 173,
		/// <summary>The volume down key.</summary>
		// Token: 0x040003FA RID: 1018
		VolumeDown = 174,
		/// <summary>The volume up key.</summary>
		// Token: 0x040003FB RID: 1019
		VolumeUp = 175,
		/// <summary>The media next track key.</summary>
		// Token: 0x040003FC RID: 1020
		MediaNextTrack = 176,
		/// <summary>The media previous track key.</summary>
		// Token: 0x040003FD RID: 1021
		MediaPreviousTrack = 177,
		/// <summary>The media Stop key.</summary>
		// Token: 0x040003FE RID: 1022
		MediaStop = 178,
		/// <summary>The media play pause key.</summary>
		// Token: 0x040003FF RID: 1023
		MediaPlayPause = 179,
		/// <summary>The launch mail key.</summary>
		// Token: 0x04000400 RID: 1024
		LaunchMail = 180,
		/// <summary>The select media key.</summary>
		// Token: 0x04000401 RID: 1025
		SelectMedia = 181,
		/// <summary>The start application one key.</summary>
		// Token: 0x04000402 RID: 1026
		LaunchApplication1 = 182,
		/// <summary>The start application two key.</summary>
		// Token: 0x04000403 RID: 1027
		LaunchApplication2 = 183,
		/// <summary>The OEM Semicolon key on a US standard keyboard.</summary>
		// Token: 0x04000404 RID: 1028
		OemSemicolon = 186,
		/// <summary>The OEM 1 key.</summary>
		// Token: 0x04000405 RID: 1029
		Oem1 = 186,
		/// <summary>The OEM plus key on any country/region keyboard.</summary>
		// Token: 0x04000406 RID: 1030
		Oemplus = 187,
		/// <summary>The OEM comma key on any country/region keyboard.</summary>
		// Token: 0x04000407 RID: 1031
		Oemcomma = 188,
		/// <summary>The OEM minus key on any country/region keyboard.</summary>
		// Token: 0x04000408 RID: 1032
		OemMinus = 189,
		/// <summary>The OEM period key on any country/region keyboard.</summary>
		// Token: 0x04000409 RID: 1033
		OemPeriod = 190,
		/// <summary>The OEM question mark key on a US standard keyboard.</summary>
		// Token: 0x0400040A RID: 1034
		OemQuestion = 191,
		/// <summary>The OEM 2 key.</summary>
		// Token: 0x0400040B RID: 1035
		Oem2 = 191,
		/// <summary>The OEM tilde key on a US standard keyboard.</summary>
		// Token: 0x0400040C RID: 1036
		Oemtilde = 192,
		/// <summary>The OEM 3 key.</summary>
		// Token: 0x0400040D RID: 1037
		Oem3 = 192,
		/// <summary>The OEM open bracket key on a US standard keyboard.</summary>
		// Token: 0x0400040E RID: 1038
		OemOpenBrackets = 219,
		/// <summary>The OEM 4 key.</summary>
		// Token: 0x0400040F RID: 1039
		Oem4 = 219,
		/// <summary>The OEM pipe key on a US standard keyboard.</summary>
		// Token: 0x04000410 RID: 1040
		OemPipe = 220,
		/// <summary>The OEM 5 key.</summary>
		// Token: 0x04000411 RID: 1041
		Oem5 = 220,
		/// <summary>The OEM close bracket key on a US standard keyboard.</summary>
		// Token: 0x04000412 RID: 1042
		OemCloseBrackets = 221,
		/// <summary>The OEM 6 key.</summary>
		// Token: 0x04000413 RID: 1043
		Oem6 = 221,
		/// <summary>The OEM singled/double quote key on a US standard keyboard.</summary>
		// Token: 0x04000414 RID: 1044
		OemQuotes = 222,
		/// <summary>The OEM 7 key.</summary>
		// Token: 0x04000415 RID: 1045
		Oem7 = 222,
		/// <summary>The OEM 8 key.</summary>
		// Token: 0x04000416 RID: 1046
		Oem8 = 223,
		/// <summary>The OEM angle bracket or backslash key on the RT 102 key keyboard.</summary>
		// Token: 0x04000417 RID: 1047
		OemBackslash = 226,
		/// <summary>The OEM 102 key.</summary>
		// Token: 0x04000418 RID: 1048
		Oem102 = 226,
		/// <summary>The PROCESS KEY key.</summary>
		// Token: 0x04000419 RID: 1049
		ProcessKey = 229,
		/// <summary>Used to pass Unicode characters as if they were keystrokes. The Packet key value is the low word of a 32-bit virtual-key value used for non-keyboard input methods.</summary>
		// Token: 0x0400041A RID: 1050
		Packet = 231,
		/// <summary>The ATTN key.</summary>
		// Token: 0x0400041B RID: 1051
		Attn = 246,
		/// <summary>The CRSEL key.</summary>
		// Token: 0x0400041C RID: 1052
		Crsel = 247,
		/// <summary>The EXSEL key.</summary>
		// Token: 0x0400041D RID: 1053
		Exsel = 248,
		/// <summary>The ERASE EOF key.</summary>
		// Token: 0x0400041E RID: 1054
		EraseEof = 249,
		/// <summary>The PLAY key.</summary>
		// Token: 0x0400041F RID: 1055
		Play = 250,
		/// <summary>The ZOOM key.</summary>
		// Token: 0x04000420 RID: 1056
		Zoom = 251,
		/// <summary>A constant reserved for future use.</summary>
		// Token: 0x04000421 RID: 1057
		NoName = 252,
		/// <summary>The PA1 key.</summary>
		// Token: 0x04000422 RID: 1058
		Pa1 = 253,
		/// <summary>The CLEAR key.</summary>
		// Token: 0x04000423 RID: 1059
		OemClear = 254,
		/// <summary>The SHIFT modifier key.</summary>
		// Token: 0x04000424 RID: 1060
		Shift = 65536,
		/// <summary>The CTRL modifier key.</summary>
		// Token: 0x04000425 RID: 1061
		Control = 131072,
		/// <summary>The ALT modifier key.</summary>
		// Token: 0x04000426 RID: 1062
		Alt = 262144
	}
}
