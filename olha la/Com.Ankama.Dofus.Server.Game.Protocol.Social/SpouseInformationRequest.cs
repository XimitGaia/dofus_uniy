using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Social;

[Token(Token = "0x2000129")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class SpouseInformationRequest : IMessage<SpouseInformationRequest>, IMessage, IEquatable<SpouseInformationRequest>, IDeepCloneable<SpouseInformationRequest>, IBufferMessage
{
	[Token(Token = "0x40003EE")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<SpouseInformationRequest> _parser;

	[Token(Token = "0x40003EF")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x1700026D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SpouseInformationRequest> Parser
	{
		[Token(Token = "0x6000B6C")]
		[Address(RVA = "0xB748E0", Offset = "0xB73CE0", VA = "0x180B748E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700026E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000B6D")]
		[Address(RVA = "0xB74830", Offset = "0xB73C30", VA = "0x180B74830")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700026F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000B6E")]
		[Address(RVA = "0xB74930", Offset = "0xB73D30", VA = "0x180B74930", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000B6F")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SpouseInformationRequest()
	{
	}

	[Token(Token = "0x6000B70")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SpouseInformationRequest(SpouseInformationRequest other)
	{
	}

	[Token(Token = "0x6000B71")]
	[Address(RVA = "0xB745D0", Offset = "0xB739D0", VA = "0x180B745D0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SpouseInformationRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6000B72")]
	[Address(RVA = "0xB74650", Offset = "0xB73A50", VA = "0x180B74650", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000B73")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(SpouseInformationRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000B74")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000B75")]
	[Address(RVA = "0xB746D0", Offset = "0xB73AD0", VA = "0x180B746D0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000B76")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000B77")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000B78")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000B79")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SpouseInformationRequest other)
	{
	}

	[Token(Token = "0x6000B7A")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000B7B")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
