using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Bak;

[Token(Token = "0x2000B5C")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class BufferInformation : IMessage<BufferInformation>, IMessage, IEquatable<BufferInformation>, IDeepCloneable<BufferInformation>, IBufferMessage
{
	[Token(Token = "0x4002A7B")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<BufferInformation> _parser;

	[Token(Token = "0x4002A7C")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002A7D")]
	public const int BufferIdFieldNumber = 1;

	[Token(Token = "0x4002A7E")]
	[FieldOffset(Offset = "0x18")]
	private long bufferId_;

	[Token(Token = "0x4002A7F")]
	public const int BufferAmountFieldNumber = 2;

	[Token(Token = "0x4002A80")]
	[FieldOffset(Offset = "0x20")]
	private long bufferAmount_;

	[Token(Token = "0x17001A5F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BufferInformation> Parser
	{
		[Token(Token = "0x60077AC")]
		[Address(RVA = "0xC21BD0", Offset = "0xC20FD0", VA = "0x180C21BD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A60")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60077AD")]
		[Address(RVA = "0xC21B20", Offset = "0xC20F20", VA = "0x180C21B20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A61")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60077AE")]
		[Address(RVA = "0xC21C20", Offset = "0xC21020", VA = "0x180C21C20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A62")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long BufferId
	{
		[Token(Token = "0x60077B2")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60077B3")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x17001A63")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long BufferAmount
	{
		[Token(Token = "0x60077B4")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60077B5")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x60077AF")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BufferInformation()
	{
	}

	[Token(Token = "0x60077B0")]
	[Address(RVA = "0x951C30", Offset = "0x951030", VA = "0x180951C30")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BufferInformation(BufferInformation other)
	{
	}

	[Token(Token = "0x60077B1")]
	[Address(RVA = "0xC21890", Offset = "0xC20C90", VA = "0x180C21890", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BufferInformation Clone()
	{
		return null;
	}

	[Token(Token = "0x60077B6")]
	[Address(RVA = "0xC21920", Offset = "0xC20D20", VA = "0x180C21920", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60077B7")]
	[Address(RVA = "0x951900", Offset = "0x950D00", VA = "0x180951900", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BufferInformation other)
	{
		return default(bool);
	}

	[Token(Token = "0x60077B8")]
	[Address(RVA = "0x9519E0", Offset = "0x950DE0", VA = "0x1809519E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60077B9")]
	[Address(RVA = "0xC219C0", Offset = "0xC20DC0", VA = "0x180C219C0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60077BA")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60077BB")]
	[Address(RVA = "0x951E40", Offset = "0x951240", VA = "0x180951E40", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60077BC")]
	[Address(RVA = "0xC217D0", Offset = "0xC20BD0", VA = "0x180C217D0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60077BD")]
	[Address(RVA = "0x951A70", Offset = "0x950E70", VA = "0x180951A70", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(BufferInformation other)
	{
	}

	[Token(Token = "0x60077BE")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60077BF")]
	[Address(RVA = "0x951D90", Offset = "0x951190", VA = "0x180951D90", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
