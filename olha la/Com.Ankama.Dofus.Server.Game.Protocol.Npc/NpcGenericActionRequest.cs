using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Npc;

[Token(Token = "0x20002CB")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class NpcGenericActionRequest : IMessage<NpcGenericActionRequest>, IMessage, IEquatable<NpcGenericActionRequest>, IDeepCloneable<NpcGenericActionRequest>, IBufferMessage
{
	[Token(Token = "0x40009D3")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<NpcGenericActionRequest> _parser;

	[Token(Token = "0x40009D4")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40009D5")]
	public const int NpcIdFieldNumber = 1;

	[Token(Token = "0x40009D6")]
	[FieldOffset(Offset = "0x18")]
	private int npcId_;

	[Token(Token = "0x40009D7")]
	public const int NpcActionIdFieldNumber = 2;

	[Token(Token = "0x40009D8")]
	[FieldOffset(Offset = "0x1C")]
	private int npcActionId_;

	[Token(Token = "0x40009D9")]
	public const int NpcMapIdFieldNumber = 3;

	[Token(Token = "0x40009DA")]
	[FieldOffset(Offset = "0x20")]
	private long npcMapId_;

	[Token(Token = "0x17000645")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NpcGenericActionRequest> Parser
	{
		[Token(Token = "0x6001D0E")]
		[Address(RVA = "0xD28AD0", Offset = "0xD27ED0", VA = "0x180D28AD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000646")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001D0F")]
		[Address(RVA = "0xD28A20", Offset = "0xD27E20", VA = "0x180D28A20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000647")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001D10")]
		[Address(RVA = "0xD28B20", Offset = "0xD27F20", VA = "0x180D28B20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000648")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int NpcId
	{
		[Token(Token = "0x6001D14")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001D15")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000649")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int NpcActionId
	{
		[Token(Token = "0x6001D16")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001D17")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x1700064A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long NpcMapId
	{
		[Token(Token = "0x6001D18")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6001D19")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x6001D11")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NpcGenericActionRequest()
	{
	}

	[Token(Token = "0x6001D12")]
	[Address(RVA = "0x962830", Offset = "0x961C30", VA = "0x180962830")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public NpcGenericActionRequest(NpcGenericActionRequest other)
	{
	}

	[Token(Token = "0x6001D13")]
	[Address(RVA = "0xD28790", Offset = "0xD27B90", VA = "0x180D28790", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public NpcGenericActionRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6001D1A")]
	[Address(RVA = "0xD28820", Offset = "0xD27C20", VA = "0x180D28820", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001D1B")]
	[Address(RVA = "0x962570", Offset = "0x961970", VA = "0x180962570", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(NpcGenericActionRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001D1C")]
	[Address(RVA = "0x9625B0", Offset = "0x9619B0", VA = "0x1809625B0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001D1D")]
	[Address(RVA = "0xD288C0", Offset = "0xD27CC0", VA = "0x180D288C0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001D1E")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001D1F")]
	[Address(RVA = "0xA26730", Offset = "0xA25B30", VA = "0x180A26730", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001D20")]
	[Address(RVA = "0xD286B0", Offset = "0xD27AB0", VA = "0x180D286B0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001D21")]
	[Address(RVA = "0x962660", Offset = "0x961A60", VA = "0x180962660", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(NpcGenericActionRequest other)
	{
	}

	[Token(Token = "0x6001D22")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001D23")]
	[Address(RVA = "0x962990", Offset = "0x961D90", VA = "0x180962990", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
