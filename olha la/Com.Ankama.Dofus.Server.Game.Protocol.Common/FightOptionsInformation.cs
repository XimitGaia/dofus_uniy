using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000A11")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightOptionsInformation : IMessage<FightOptionsInformation>, IMessage, IEquatable<FightOptionsInformation>, IDeepCloneable<FightOptionsInformation>, IBufferMessage
{
	[Token(Token = "0x4002408")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FightOptionsInformation> _parser;

	[Token(Token = "0x4002409")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400240A")]
	public const int IsSecretFieldNumber = 1;

	[Token(Token = "0x400240B")]
	[FieldOffset(Offset = "0x18")]
	private bool isSecret_;

	[Token(Token = "0x400240C")]
	public const int IsRestrictedToPartyFieldNumber = 2;

	[Token(Token = "0x400240D")]
	[FieldOffset(Offset = "0x19")]
	private bool isRestrictedToParty_;

	[Token(Token = "0x400240E")]
	public const int IsClosedFieldNumber = 3;

	[Token(Token = "0x400240F")]
	[FieldOffset(Offset = "0x1A")]
	private bool isClosed_;

	[Token(Token = "0x4002410")]
	public const int IsAskingForHelpFieldNumber = 4;

	[Token(Token = "0x4002411")]
	[FieldOffset(Offset = "0x1B")]
	private bool isAskingForHelp_;

	[Token(Token = "0x1700169C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FightOptionsInformation> Parser
	{
		[Token(Token = "0x60068FE")]
		[Address(RVA = "0xBB6960", Offset = "0xBB5D60", VA = "0x180BB6960")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700169D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60068FF")]
		[Address(RVA = "0xBB68B0", Offset = "0xBB5CB0", VA = "0x180BB68B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700169E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6006900")]
		[Address(RVA = "0xBB6B80", Offset = "0xBB5F80", VA = "0x180BB6B80", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700169F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool IsSecret
	{
		[Token(Token = "0x6006904")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6006905")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x170016A0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool IsRestrictedToParty
	{
		[Token(Token = "0x6006906")]
		[Address(RVA = "0x87EAB0", Offset = "0x87DEB0", VA = "0x18087EAB0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6006907")]
		[Address(RVA = "0x87EAF0", Offset = "0x87DEF0", VA = "0x18087EAF0")]
		set
		{
		}
	}

	[Token(Token = "0x170016A1")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool IsClosed
	{
		[Token(Token = "0x6006908")]
		[Address(RVA = "0x928A60", Offset = "0x927E60", VA = "0x180928A60")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6006909")]
		[Address(RVA = "0x928D50", Offset = "0x928150", VA = "0x180928D50")]
		set
		{
		}
	}

	[Token(Token = "0x170016A2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool IsAskingForHelp
	{
		[Token(Token = "0x600690A")]
		[Address(RVA = "0x928A00", Offset = "0x927E00", VA = "0x180928A00")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600690B")]
		[Address(RVA = "0x928D30", Offset = "0x928130", VA = "0x180928D30")]
		set
		{
		}
	}

	[Token(Token = "0x6006901")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightOptionsInformation()
	{
	}

	[Token(Token = "0x6006902")]
	[Address(RVA = "0xBB6840", Offset = "0xBB5C40", VA = "0x180BB6840")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightOptionsInformation(FightOptionsInformation other)
	{
	}

	[Token(Token = "0x6006903")]
	[Address(RVA = "0xBB63A0", Offset = "0xBB57A0", VA = "0x180BB63A0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightOptionsInformation Clone()
	{
		return null;
	}

	[Token(Token = "0x600690C")]
	[Address(RVA = "0xBB6440", Offset = "0xBB5840", VA = "0x180BB6440", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600690D")]
	[Address(RVA = "0xBB64F0", Offset = "0xBB58F0", VA = "0x180BB64F0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FightOptionsInformation other)
	{
		return default(bool);
	}

	[Token(Token = "0x600690E")]
	[Address(RVA = "0xBB6540", Offset = "0xBB5940", VA = "0x180BB6540", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600690F")]
	[Address(RVA = "0xBB66E0", Offset = "0xBB5AE0", VA = "0x180BB66E0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6006910")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6006911")]
	[Address(RVA = "0xBB6AC0", Offset = "0xBB5EC0", VA = "0x180BB6AC0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6006912")]
	[Address(RVA = "0xBB6340", Offset = "0xBB5740", VA = "0x180BB6340", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6006913")]
	[Address(RVA = "0xBB6670", Offset = "0xBB5A70", VA = "0x180BB6670", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FightOptionsInformation other)
	{
	}

	[Token(Token = "0x6006914")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6006915")]
	[Address(RVA = "0xBB69B0", Offset = "0xBB5DB0", VA = "0x180BB69B0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
