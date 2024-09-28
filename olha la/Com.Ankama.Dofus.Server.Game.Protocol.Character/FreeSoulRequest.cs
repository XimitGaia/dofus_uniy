using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character;

[Token(Token = "0x2000865")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FreeSoulRequest : IMessage<FreeSoulRequest>, IMessage, IEquatable<FreeSoulRequest>, IDeepCloneable<FreeSoulRequest>, IBufferMessage
{
	[Token(Token = "0x4001D16")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FreeSoulRequest> _parser;

	[Token(Token = "0x4001D17")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x170012FE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FreeSoulRequest> Parser
	{
		[Token(Token = "0x6005931")]
		[Address(RVA = "0xB26B40", Offset = "0xB25F40", VA = "0x180B26B40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012FF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005932")]
		[Address(RVA = "0xB26A90", Offset = "0xB25E90", VA = "0x180B26A90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001300")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005933")]
		[Address(RVA = "0xB26B90", Offset = "0xB25F90", VA = "0x180B26B90", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005934")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FreeSoulRequest()
	{
	}

	[Token(Token = "0x6005935")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FreeSoulRequest(FreeSoulRequest other)
	{
	}

	[Token(Token = "0x6005936")]
	[Address(RVA = "0xB26830", Offset = "0xB25C30", VA = "0x180B26830", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FreeSoulRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6005937")]
	[Address(RVA = "0xB268B0", Offset = "0xB25CB0", VA = "0x180B268B0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005938")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FreeSoulRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005939")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600593A")]
	[Address(RVA = "0xB26930", Offset = "0xB25D30", VA = "0x180B26930", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600593B")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600593C")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600593D")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600593E")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FreeSoulRequest other)
	{
	}

	[Token(Token = "0x600593F")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005940")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
