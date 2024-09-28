using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Server;

[Token(Token = "0x200014D")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ServerSettingsEvent : IMessage<ServerSettingsEvent>, IMessage, IEquatable<ServerSettingsEvent>, IDeepCloneable<ServerSettingsEvent>, IBufferMessage
{
	[Token(Token = "0x400046D")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ServerSettingsEvent> _parser;

	[Token(Token = "0x400046E")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400046F")]
	public const int LanguageFieldNumber = 1;

	[Token(Token = "0x4000470")]
	[FieldOffset(Offset = "0x18")]
	private string language_;

	[Token(Token = "0x4000471")]
	public const int CommunityFieldNumber = 2;

	[Token(Token = "0x4000472")]
	[FieldOffset(Offset = "0x20")]
	private int community_;

	[Token(Token = "0x4000473")]
	public const int GameTypeFieldNumber = 3;

	[Token(Token = "0x4000474")]
	[FieldOffset(Offset = "0x24")]
	private ServerType gameType_;

	[Token(Token = "0x4000475")]
	public const int IsMonoAccountFieldNumber = 4;

	[Token(Token = "0x4000476")]
	[FieldOffset(Offset = "0x28")]
	private bool isMonoAccount_;

	[Token(Token = "0x4000477")]
	public const int ArenaLeaveBanTimeFieldNumber = 5;

	[Token(Token = "0x4000478")]
	[FieldOffset(Offset = "0x2C")]
	private int arenaLeaveBanTime_;

	[Token(Token = "0x4000479")]
	public const int ItemMaxLevelFieldNumber = 6;

	[Token(Token = "0x400047A")]
	[FieldOffset(Offset = "0x30")]
	private int itemMaxLevel_;

	[Token(Token = "0x400047B")]
	public const int HasFreeAutopilotFieldNumber = 7;

	[Token(Token = "0x400047C")]
	[FieldOffset(Offset = "0x34")]
	private bool hasFreeAutopilot_;

	[Token(Token = "0x170002C1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ServerSettingsEvent> Parser
	{
		[Token(Token = "0x6000CE4")]
		[Address(RVA = "0xB6C370", Offset = "0xB6B770", VA = "0x180B6C370")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002C2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000CE5")]
		[Address(RVA = "0xB6C2C0", Offset = "0xB6B6C0", VA = "0x180B6C2C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002C3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000CE6")]
		[Address(RVA = "0xB6C670", Offset = "0xB6BA70", VA = "0x180B6C670", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002C4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Language
	{
		[Token(Token = "0x6000CEA")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000CEB")]
		[Address(RVA = "0xB6C750", Offset = "0xB6BB50", VA = "0x180B6C750")]
		set
		{
		}
	}

	[Token(Token = "0x170002C5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Community
	{
		[Token(Token = "0x6000CEC")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000CED")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x170002C6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ServerType GameType
	{
		[Token(Token = "0x6000CEE")]
		[Address(RVA = "0x87D140", Offset = "0x87C540", VA = "0x18087D140")]
		get
		{
			return default(ServerType);
		}
		[Token(Token = "0x6000CEF")]
		[Address(RVA = "0x9342C0", Offset = "0x9336C0", VA = "0x1809342C0")]
		set
		{
		}
	}

	[Token(Token = "0x170002C7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsMonoAccount
	{
		[Token(Token = "0x6000CF0")]
		[Address(RVA = "0x8529D0", Offset = "0x851DD0", VA = "0x1808529D0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000CF1")]
		[Address(RVA = "0x9A1E80", Offset = "0x9A1280", VA = "0x1809A1E80")]
		set
		{
		}
	}

	[Token(Token = "0x170002C8")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ArenaLeaveBanTime
	{
		[Token(Token = "0x6000CF2")]
		[Address(RVA = "0x95FBF0", Offset = "0x95EFF0", VA = "0x18095FBF0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000CF3")]
		[Address(RVA = "0x960010", Offset = "0x95F410", VA = "0x180960010")]
		set
		{
		}
	}

	[Token(Token = "0x170002C9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ItemMaxLevel
	{
		[Token(Token = "0x6000CF4")]
		[Address(RVA = "0x875C10", Offset = "0x875010", VA = "0x180875C10")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000CF5")]
		[Address(RVA = "0x947120", Offset = "0x946520", VA = "0x180947120")]
		set
		{
		}
	}

	[Token(Token = "0x170002CA")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool HasFreeAutopilot
	{
		[Token(Token = "0x6000CF6")]
		[Address(RVA = "0x96E6E0", Offset = "0x96DAE0", VA = "0x18096E6E0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000CF7")]
		[Address(RVA = "0x96EC10", Offset = "0x96E010", VA = "0x18096EC10")]
		set
		{
		}
	}

	[Token(Token = "0x6000CE7")]
	[Address(RVA = "0xB6C270", Offset = "0xB6B670", VA = "0x180B6C270")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ServerSettingsEvent()
	{
	}

	[Token(Token = "0x6000CE8")]
	[Address(RVA = "0xB6C1A0", Offset = "0xB6B5A0", VA = "0x180B6C1A0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ServerSettingsEvent(ServerSettingsEvent other)
	{
	}

	[Token(Token = "0x6000CE9")]
	[Address(RVA = "0xB6BBD0", Offset = "0xB6AFD0", VA = "0x180B6BBD0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ServerSettingsEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6000CF8")]
	[Address(RVA = "0xB6BCC0", Offset = "0xB6B0C0", VA = "0x180B6BCC0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000CF9")]
	[Address(RVA = "0xB6BDA0", Offset = "0xB6B1A0", VA = "0x180B6BDA0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ServerSettingsEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000CFA")]
	[Address(RVA = "0xB6BE40", Offset = "0xB6B240", VA = "0x180B6BE40", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000CFB")]
	[Address(RVA = "0xB6C040", Offset = "0xB6B440", VA = "0x180B6C040", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000CFC")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000CFD")]
	[Address(RVA = "0xB6C540", Offset = "0xB6B940", VA = "0x180B6C540", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000CFE")]
	[Address(RVA = "0xB6BA80", Offset = "0xB6AE80", VA = "0x180B6BA80", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000CFF")]
	[Address(RVA = "0xB6BFA0", Offset = "0xB6B3A0", VA = "0x180B6BFA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ServerSettingsEvent other)
	{
	}

	[Token(Token = "0x6000D00")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000D01")]
	[Address(RVA = "0xB6C3C0", Offset = "0xB6B7C0", VA = "0x180B6C3C0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
