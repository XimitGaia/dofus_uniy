using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Information;

[Token(Token = "0x2000CAF")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceModificationStartedEvent : IMessage<AllianceModificationStartedEvent>, IMessage, IEquatable<AllianceModificationStartedEvent>, IDeepCloneable<AllianceModificationStartedEvent>, IBufferMessage
{
	[Token(Token = "0x4002EB2")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceModificationStartedEvent> _parser;

	[Token(Token = "0x4002EB3")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002EB4")]
	public const int CanChangeNameFieldNumber = 1;

	[Token(Token = "0x4002EB5")]
	[FieldOffset(Offset = "0x18")]
	private bool canChangeName_;

	[Token(Token = "0x4002EB6")]
	public const int CanChangeTagFieldNumber = 2;

	[Token(Token = "0x4002EB7")]
	[FieldOffset(Offset = "0x19")]
	private bool canChangeTag_;

	[Token(Token = "0x4002EB8")]
	public const int CanChangeEmblemFieldNumber = 3;

	[Token(Token = "0x4002EB9")]
	[FieldOffset(Offset = "0x1A")]
	private bool canChangeEmblem_;

	[Token(Token = "0x17001D37")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AllianceModificationStartedEvent> Parser
	{
		[Token(Token = "0x6008599")]
		[Address(RVA = "0xC99500", Offset = "0xC98900", VA = "0x180C99500")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D38")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600859A")]
		[Address(RVA = "0xC99450", Offset = "0xC98850", VA = "0x180C99450")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D39")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600859B")]
		[Address(RVA = "0xC996D0", Offset = "0xC98AD0", VA = "0x180C996D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D3A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool CanChangeName
	{
		[Token(Token = "0x600859F")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60085A0")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x17001D3B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool CanChangeTag
	{
		[Token(Token = "0x60085A1")]
		[Address(RVA = "0x87EAB0", Offset = "0x87DEB0", VA = "0x18087EAB0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60085A2")]
		[Address(RVA = "0x87EAF0", Offset = "0x87DEF0", VA = "0x18087EAF0")]
		set
		{
		}
	}

	[Token(Token = "0x17001D3C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool CanChangeEmblem
	{
		[Token(Token = "0x60085A3")]
		[Address(RVA = "0x928A60", Offset = "0x927E60", VA = "0x180928A60")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60085A4")]
		[Address(RVA = "0x928D50", Offset = "0x928150", VA = "0x180928D50")]
		set
		{
		}
	}

	[Token(Token = "0x600859C")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceModificationStartedEvent()
	{
	}

	[Token(Token = "0x600859D")]
	[Address(RVA = "0xC993F0", Offset = "0xC987F0", VA = "0x180C993F0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceModificationStartedEvent(AllianceModificationStartedEvent other)
	{
	}

	[Token(Token = "0x600859E")]
	[Address(RVA = "0xC98FB0", Offset = "0xC983B0", VA = "0x180C98FB0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceModificationStartedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60085A5")]
	[Address(RVA = "0xC99040", Offset = "0xC98440", VA = "0x180C99040", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60085A6")]
	[Address(RVA = "0xC990E0", Offset = "0xC984E0", VA = "0x180C990E0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AllianceModificationStartedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60085A7")]
	[Address(RVA = "0xC99120", Offset = "0xC98520", VA = "0x180C99120", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60085A8")]
	[Address(RVA = "0xC99290", Offset = "0xC98690", VA = "0x180C99290", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60085A9")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60085AA")]
	[Address(RVA = "0xC99630", Offset = "0xC98A30", VA = "0x180C99630", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60085AB")]
	[Address(RVA = "0xC98F60", Offset = "0xC98360", VA = "0x180C98F60", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60085AC")]
	[Address(RVA = "0xC99220", Offset = "0xC98620", VA = "0x180C99220", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(AllianceModificationStartedEvent other)
	{
	}

	[Token(Token = "0x60085AD")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60085AE")]
	[Address(RVA = "0xC99550", Offset = "0xC98950", VA = "0x180C99550", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
