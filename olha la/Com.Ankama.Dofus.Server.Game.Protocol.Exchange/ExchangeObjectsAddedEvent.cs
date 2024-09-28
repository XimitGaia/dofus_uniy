using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x2000695")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeObjectsAddedEvent : IMessage<ExchangeObjectsAddedEvent>, IMessage, IEquatable<ExchangeObjectsAddedEvent>, IDeepCloneable<ExchangeObjectsAddedEvent>, IBufferMessage
{
	[Token(Token = "0x4001701")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeObjectsAddedEvent> _parser;

	[Token(Token = "0x4001702")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001703")]
	[FieldOffset(Offset = "0x18")]
	private int _hasBits0;

	[Token(Token = "0x4001704")]
	public const int RemoteFieldNumber = 1;

	[Token(Token = "0x4001705")]
	[FieldOffset(Offset = "0x1C")]
	private bool remote_;

	[Token(Token = "0x4001706")]
	public const int ObjectsFieldNumber = 2;

	[Token(Token = "0x4001707")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<ObjectItemInventory> _repeated_objects_codec;

	[Token(Token = "0x4001708")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<ObjectItemInventory> objects_;

	[Token(Token = "0x4001709")]
	public const int FmPowerFieldNumber = 3;

	[Token(Token = "0x400170A")]
	[FieldOffset(Offset = "0x10")]
	private static readonly float FmPowerDefaultValue;

	[Token(Token = "0x400170B")]
	[FieldOffset(Offset = "0x28")]
	private float fmPower_;

	[Token(Token = "0x17000F13")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ExchangeObjectsAddedEvent> Parser
	{
		[Token(Token = "0x6004692")]
		[Address(RVA = "0xA92E80", Offset = "0xA92280", VA = "0x180A92E80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F14")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004693")]
		[Address(RVA = "0xA92D60", Offset = "0xA92160", VA = "0x180A92D60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F15")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004694")]
		[Address(RVA = "0xA93170", Offset = "0xA92570", VA = "0x180A93170", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F16")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Remote
	{
		[Token(Token = "0x6004698")]
		[Address(RVA = "0x8F7940", Offset = "0x8F6D40", VA = "0x1808F7940")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6004699")]
		[Address(RVA = "0x928D40", Offset = "0x928140", VA = "0x180928D40")]
		set
		{
		}
	}

	[Token(Token = "0x17000F17")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<ObjectItemInventory> Objects
	{
		[Token(Token = "0x600469A")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F18")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public float FmPower
	{
		[Token(Token = "0x600469B")]
		[Address(RVA = "0xA92E10", Offset = "0xA92210", VA = "0x180A92E10")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600469C")]
		[Address(RVA = "0xA93250", Offset = "0xA92650", VA = "0x180A93250")]
		set
		{
		}
	}

	[Token(Token = "0x17000F19")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasFmPower
	{
		[Token(Token = "0x600469D")]
		[Address(RVA = "0x87E8D0", Offset = "0x87DCD0", VA = "0x18087E8D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6004695")]
	[Address(RVA = "0xA92CE0", Offset = "0xA920E0", VA = "0x180A92CE0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeObjectsAddedEvent()
	{
	}

	[Token(Token = "0x6004696")]
	[Address(RVA = "0xA92C40", Offset = "0xA92040", VA = "0x180A92C40")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeObjectsAddedEvent(ExchangeObjectsAddedEvent other)
	{
	}

	[Token(Token = "0x6004697")]
	[Address(RVA = "0xA924A0", Offset = "0xA918A0", VA = "0x180A924A0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeObjectsAddedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600469E")]
	[Address(RVA = "0x92D290", Offset = "0x92C690", VA = "0x18092D290")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearFmPower()
	{
	}

	[Token(Token = "0x600469F")]
	[Address(RVA = "0xA92570", Offset = "0xA91970", VA = "0x180A92570", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60046A0")]
	[Address(RVA = "0xA926C0", Offset = "0xA91AC0", VA = "0x180A926C0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(ExchangeObjectsAddedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60046A1")]
	[Address(RVA = "0xA927D0", Offset = "0xA91BD0", VA = "0x180A927D0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60046A2")]
	[Address(RVA = "0xA92A20", Offset = "0xA91E20", VA = "0x180A92A20", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60046A3")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60046A4")]
	[Address(RVA = "0xA93020", Offset = "0xA92420", VA = "0x180A93020", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60046A5")]
	[Address(RVA = "0xA923E0", Offset = "0xA917E0", VA = "0x180A923E0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60046A6")]
	[Address(RVA = "0xA92980", Offset = "0xA91D80", VA = "0x180A92980", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeObjectsAddedEvent other)
	{
	}

	[Token(Token = "0x60046A7")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60046A8")]
	[Address(RVA = "0xA92ED0", Offset = "0xA922D0", VA = "0x180A92ED0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
