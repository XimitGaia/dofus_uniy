using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x20009FB")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class StatedElement : IMessage<StatedElement>, IMessage, IEquatable<StatedElement>, IDeepCloneable<StatedElement>, IBufferMessage
{
	[Token(Token = "0x40023A1")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<StatedElement> _parser;

	[Token(Token = "0x40023A2")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40023A3")]
	public const int ElementIdFieldNumber = 1;

	[Token(Token = "0x40023A4")]
	[FieldOffset(Offset = "0x18")]
	private int elementId_;

	[Token(Token = "0x40023A5")]
	public const int CellIdFieldNumber = 2;

	[Token(Token = "0x40023A6")]
	[FieldOffset(Offset = "0x1C")]
	private int cellId_;

	[Token(Token = "0x40023A7")]
	public const int StateFieldNumber = 3;

	[Token(Token = "0x40023A8")]
	[FieldOffset(Offset = "0x20")]
	private int state_;

	[Token(Token = "0x40023A9")]
	public const int OnCurrentMapFieldNumber = 4;

	[Token(Token = "0x40023AA")]
	[FieldOffset(Offset = "0x24")]
	private bool onCurrentMap_;

	[Token(Token = "0x17001666")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<StatedElement> Parser
	{
		[Token(Token = "0x6006828")]
		[Address(RVA = "0xBB1710", Offset = "0xBB0B10", VA = "0x180BB1710")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001667")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6006829")]
		[Address(RVA = "0xBB1660", Offset = "0xBB0A60", VA = "0x180BB1660")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001668")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600682A")]
		[Address(RVA = "0xBB1820", Offset = "0xBB0C20", VA = "0x180BB1820", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001669")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ElementId
	{
		[Token(Token = "0x600682E")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600682F")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x1700166A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CellId
	{
		[Token(Token = "0x6006830")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006831")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x1700166B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int State
	{
		[Token(Token = "0x6006832")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006833")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x1700166C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool OnCurrentMap
	{
		[Token(Token = "0x6006834")]
		[Address(RVA = "0xA7E460", Offset = "0xA7D860", VA = "0x180A7E460")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6006835")]
		[Address(RVA = "0xA7E710", Offset = "0xA7DB10", VA = "0x180A7E710")]
		set
		{
		}
	}

	[Token(Token = "0x600682B")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StatedElement()
	{
	}

	[Token(Token = "0x600682C")]
	[Address(RVA = "0xA7E300", Offset = "0xA7D700", VA = "0x180A7E300")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public StatedElement(StatedElement other)
	{
	}

	[Token(Token = "0x600682D")]
	[Address(RVA = "0xBB12E0", Offset = "0xBB06E0", VA = "0x180BB12E0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StatedElement Clone()
	{
		return null;
	}

	[Token(Token = "0x6006836")]
	[Address(RVA = "0xBB1370", Offset = "0xBB0770", VA = "0x180BB1370", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006837")]
	[Address(RVA = "0xA7DFE0", Offset = "0xA7D3E0", VA = "0x180A7DFE0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(StatedElement other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006838")]
	[Address(RVA = "0xBB1410", Offset = "0xBB0810", VA = "0x180BB1410", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6006839")]
	[Address(RVA = "0xBB1500", Offset = "0xBB0900", VA = "0x180BB1500", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600683A")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600683B")]
	[Address(RVA = "0xBB1760", Offset = "0xBB0B60", VA = "0x180BB1760", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600683C")]
	[Address(RVA = "0xBB11F0", Offset = "0xBB05F0", VA = "0x180BB11F0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600683D")]
	[Address(RVA = "0xA7E130", Offset = "0xA7D530", VA = "0x180A7E130", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(StatedElement other)
	{
	}

	[Token(Token = "0x600683E")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600683F")]
	[Address(RVA = "0xA7E470", Offset = "0xA7D870", VA = "0x180A7E470", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
