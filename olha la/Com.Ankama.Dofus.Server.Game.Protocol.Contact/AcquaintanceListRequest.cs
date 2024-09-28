using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact;

[Token(Token = "0x20007C0")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AcquaintanceListRequest : IMessage<AcquaintanceListRequest>, IMessage, IEquatable<AcquaintanceListRequest>, IDeepCloneable<AcquaintanceListRequest>, IBufferMessage
{
	[Token(Token = "0x4001AE6")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AcquaintanceListRequest> _parser;

	[Token(Token = "0x4001AE7")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x1700118F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<AcquaintanceListRequest> Parser
	{
		[Token(Token = "0x600525E")]
		[Address(RVA = "0xAE59B0", Offset = "0xAE4DB0", VA = "0x180AE59B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001190")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600525F")]
		[Address(RVA = "0xAE5900", Offset = "0xAE4D00", VA = "0x180AE5900")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001191")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005260")]
		[Address(RVA = "0xAE5A00", Offset = "0xAE4E00", VA = "0x180AE5A00", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005261")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AcquaintanceListRequest()
	{
	}

	[Token(Token = "0x6005262")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AcquaintanceListRequest(AcquaintanceListRequest other)
	{
	}

	[Token(Token = "0x6005263")]
	[Address(RVA = "0xAE56A0", Offset = "0xAE4AA0", VA = "0x180AE56A0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AcquaintanceListRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6005264")]
	[Address(RVA = "0xAE5720", Offset = "0xAE4B20", VA = "0x180AE5720", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005265")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(AcquaintanceListRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005266")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005267")]
	[Address(RVA = "0xAE57A0", Offset = "0xAE4BA0", VA = "0x180AE57A0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005268")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005269")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600526A")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600526B")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AcquaintanceListRequest other)
	{
	}

	[Token(Token = "0x600526C")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600526D")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
