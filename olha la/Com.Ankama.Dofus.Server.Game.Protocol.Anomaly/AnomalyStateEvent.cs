using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Anomaly;

[Token(Token = "0x2000C3C")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AnomalyStateEvent : IMessage<AnomalyStateEvent>, IMessage, IEquatable<AnomalyStateEvent>, IDeepCloneable<AnomalyStateEvent>, IBufferMessage
{
	[Token(Token = "0x4002D65")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AnomalyStateEvent> _parser;

	[Token(Token = "0x4002D66")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002D67")]
	public const int SubareaIdFieldNumber = 1;

	[Token(Token = "0x4002D68")]
	[FieldOffset(Offset = "0x18")]
	private int subareaId_;

	[Token(Token = "0x4002D69")]
	public const int OpenFieldNumber = 2;

	[Token(Token = "0x4002D6A")]
	[FieldOffset(Offset = "0x1C")]
	private bool open_;

	[Token(Token = "0x4002D6B")]
	public const int ClosingTimeFieldNumber = 3;

	[Token(Token = "0x4002D6C")]
	[FieldOffset(Offset = "0x20")]
	private long closingTime_;

	[Token(Token = "0x17001C44")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AnomalyStateEvent> Parser
	{
		[Token(Token = "0x60080C6")]
		[Address(RVA = "0xC84460", Offset = "0xC83860", VA = "0x180C84460")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C45")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60080C7")]
		[Address(RVA = "0xC843B0", Offset = "0xC837B0", VA = "0x180C843B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C46")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60080C8")]
		[Address(RVA = "0xC84620", Offset = "0xC83A20", VA = "0x180C84620", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C47")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SubareaId
	{
		[Token(Token = "0x60080CC")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60080CD")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17001C48")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Open
	{
		[Token(Token = "0x60080CE")]
		[Address(RVA = "0x8F7940", Offset = "0x8F6D40", VA = "0x1808F7940")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60080CF")]
		[Address(RVA = "0x928D40", Offset = "0x928140", VA = "0x180928D40")]
		set
		{
		}
	}

	[Token(Token = "0x17001C49")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long ClosingTime
	{
		[Token(Token = "0x60080D0")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60080D1")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x60080C9")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AnomalyStateEvent()
	{
	}

	[Token(Token = "0x60080CA")]
	[Address(RVA = "0xC84350", Offset = "0xC83750", VA = "0x180C84350")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AnomalyStateEvent(AnomalyStateEvent other)
	{
	}

	[Token(Token = "0x60080CB")]
	[Address(RVA = "0xC83F30", Offset = "0xC83330", VA = "0x180C83F30", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AnomalyStateEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60080D2")]
	[Address(RVA = "0xC83FC0", Offset = "0xC833C0", VA = "0x180C83FC0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60080D3")]
	[Address(RVA = "0xC84060", Offset = "0xC83460", VA = "0x180C84060", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AnomalyStateEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60080D4")]
	[Address(RVA = "0xC840A0", Offset = "0xC834A0", VA = "0x180C840A0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60080D5")]
	[Address(RVA = "0xC841F0", Offset = "0xC835F0", VA = "0x180C841F0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60080D6")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60080D7")]
	[Address(RVA = "0xC84580", Offset = "0xC83980", VA = "0x180C84580", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60080D8")]
	[Address(RVA = "0xC83E70", Offset = "0xC83270", VA = "0x180C83E70", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60080D9")]
	[Address(RVA = "0xC84180", Offset = "0xC83580", VA = "0x180C84180", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(AnomalyStateEvent other)
	{
	}

	[Token(Token = "0x60080DA")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60080DB")]
	[Address(RVA = "0xC844B0", Offset = "0xC838B0", VA = "0x180C844B0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
