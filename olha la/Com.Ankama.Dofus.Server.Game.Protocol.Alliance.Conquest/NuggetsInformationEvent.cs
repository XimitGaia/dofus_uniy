using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Conquest;

[Token(Token = "0x2000D01")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class NuggetsInformationEvent : IMessage<NuggetsInformationEvent>, IMessage, IEquatable<NuggetsInformationEvent>, IDeepCloneable<NuggetsInformationEvent>, IBufferMessage
{
	[Token(Token = "0x4002FCD")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<NuggetsInformationEvent> _parser;

	[Token(Token = "0x4002FCE")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002FCF")]
	public const int NuggetsQuantityFieldNumber = 1;

	[Token(Token = "0x4002FD0")]
	[FieldOffset(Offset = "0x18")]
	private int nuggetsQuantity_;

	[Token(Token = "0x17001DEF")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<NuggetsInformationEvent> Parser
	{
		[Token(Token = "0x6008903")]
		[Address(RVA = "0xCB5A30", Offset = "0xCB4E30", VA = "0x180CB5A30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001DF0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6008904")]
		[Address(RVA = "0xCB5980", Offset = "0xCB4D80", VA = "0x180CB5980")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001DF1")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6008905")]
		[Address(RVA = "0xCB5A80", Offset = "0xCB4E80", VA = "0x180CB5A80", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001DF2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int NuggetsQuantity
	{
		[Token(Token = "0x6008909")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600890A")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6008906")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NuggetsInformationEvent()
	{
	}

	[Token(Token = "0x6008907")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NuggetsInformationEvent(NuggetsInformationEvent other)
	{
	}

	[Token(Token = "0x6008908")]
	[Address(RVA = "0xCB5710", Offset = "0xCB4B10", VA = "0x180CB5710", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NuggetsInformationEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600890B")]
	[Address(RVA = "0xCB5790", Offset = "0xCB4B90", VA = "0x180CB5790", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600890C")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(NuggetsInformationEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600890D")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600890E")]
	[Address(RVA = "0xCB5820", Offset = "0xCB4C20", VA = "0x180CB5820", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600890F")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6008910")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6008911")]
	[Address(RVA = "0xCB5680", Offset = "0xCB4A80", VA = "0x180CB5680", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6008912")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NuggetsInformationEvent other)
	{
	}

	[Token(Token = "0x6008913")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6008914")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
