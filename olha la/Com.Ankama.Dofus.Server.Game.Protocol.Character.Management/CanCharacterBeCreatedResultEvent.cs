using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character.Management;

[Token(Token = "0x20008A0")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CanCharacterBeCreatedResultEvent : IMessage<CanCharacterBeCreatedResultEvent>, IMessage, IEquatable<CanCharacterBeCreatedResultEvent>, IDeepCloneable<CanCharacterBeCreatedResultEvent>, IBufferMessage
{
	[Token(Token = "0x4001DC2")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CanCharacterBeCreatedResultEvent> _parser;

	[Token(Token = "0x4001DC3")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001DC4")]
	public const int ResultFieldNumber = 1;

	[Token(Token = "0x4001DC5")]
	[FieldOffset(Offset = "0x18")]
	private bool result_;

	[Token(Token = "0x17001373")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<CanCharacterBeCreatedResultEvent> Parser
	{
		[Token(Token = "0x6005B88")]
		[Address(RVA = "0xB14E90", Offset = "0xB14290", VA = "0x180B14E90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001374")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005B89")]
		[Address(RVA = "0xB14DE0", Offset = "0xB141E0", VA = "0x180B14DE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001375")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005B8A")]
		[Address(RVA = "0xB14EE0", Offset = "0xB142E0", VA = "0x180B14EE0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001376")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Result
	{
		[Token(Token = "0x6005B8E")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6005B8F")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x6005B8B")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CanCharacterBeCreatedResultEvent()
	{
	}

	[Token(Token = "0x6005B8C")]
	[Address(RVA = "0x951480", Offset = "0x950880", VA = "0x180951480")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CanCharacterBeCreatedResultEvent(CanCharacterBeCreatedResultEvent other)
	{
	}

	[Token(Token = "0x6005B8D")]
	[Address(RVA = "0xB14AD0", Offset = "0xB13ED0", VA = "0x180B14AD0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CanCharacterBeCreatedResultEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6005B90")]
	[Address(RVA = "0xB14B50", Offset = "0xB13F50", VA = "0x180B14B50", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005B91")]
	[Address(RVA = "0x951170", Offset = "0x950570", VA = "0x180951170", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CanCharacterBeCreatedResultEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005B92")]
	[Address(RVA = "0xB14BE0", Offset = "0xB13FE0", VA = "0x180B14BE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005B93")]
	[Address(RVA = "0xB14C80", Offset = "0xB14080", VA = "0x180B14C80", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005B94")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005B95")]
	[Address(RVA = "0x951670", Offset = "0x950A70", VA = "0x180951670", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005B96")]
	[Address(RVA = "0x9510B0", Offset = "0x9504B0", VA = "0x1809510B0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005B97")]
	[Address(RVA = "0x9512D0", Offset = "0x9506D0", VA = "0x1809512D0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CanCharacterBeCreatedResultEvent other)
	{
	}

	[Token(Token = "0x6005B98")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005B99")]
	[Address(RVA = "0x9515D0", Offset = "0x9509D0", VA = "0x1809515D0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
