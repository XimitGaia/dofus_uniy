using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset;

[Token(Token = "0x20001D5")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class Ride : IMessage<Ride>, IMessage, IEquatable<Ride>, IDeepCloneable<Ride>, IBufferMessage
{
	[Token(Token = "0x4000644")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<Ride> _parser;

	[Token(Token = "0x4000645")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000646")]
	public const int ModelIdFieldNumber = 1;

	[Token(Token = "0x4000647")]
	[FieldOffset(Offset = "0x18")]
	private int modelId_;

	[Token(Token = "0x4000648")]
	public const int LevelFieldNumber = 2;

	[Token(Token = "0x4000649")]
	[FieldOffset(Offset = "0x1C")]
	private int level_;

	[Token(Token = "0x400064A")]
	public const int IsCurrentRideFieldNumber = 3;

	[Token(Token = "0x400064B")]
	[FieldOffset(Offset = "0x20")]
	private bool isCurrentRide_;

	[Token(Token = "0x17000402")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<Ride> Parser
	{
		[Token(Token = "0x60012AF")]
		[Address(RVA = "0xCD5CB0", Offset = "0xCD50B0", VA = "0x180CD5CB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000403")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60012B0")]
		[Address(RVA = "0xCD5C00", Offset = "0xCD5000", VA = "0x180CD5C00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000404")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60012B1")]
		[Address(RVA = "0xCD5D00", Offset = "0xCD5100", VA = "0x180CD5D00", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000405")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ModelId
	{
		[Token(Token = "0x60012B5")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60012B6")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000406")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Level
	{
		[Token(Token = "0x60012B7")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60012B8")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x17000407")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool IsCurrentRide
	{
		[Token(Token = "0x60012B9")]
		[Address(RVA = "0x7F9A60", Offset = "0x7F8E60", VA = "0x1807F9A60")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60012BA")]
		[Address(RVA = "0x7F9A70", Offset = "0x7F8E70", VA = "0x1807F9A70")]
		set
		{
		}
	}

	[Token(Token = "0x60012B2")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Ride()
	{
	}

	[Token(Token = "0x60012B3")]
	[Address(RVA = "0x92C240", Offset = "0x92B640", VA = "0x18092C240")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Ride(Ride other)
	{
	}

	[Token(Token = "0x60012B4")]
	[Address(RVA = "0xCD5890", Offset = "0xCD4C90", VA = "0x180CD5890", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Ride Clone()
	{
		return null;
	}

	[Token(Token = "0x60012BB")]
	[Address(RVA = "0xCD5920", Offset = "0xCD4D20", VA = "0x180CD5920", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60012BC")]
	[Address(RVA = "0x92BF50", Offset = "0x92B350", VA = "0x18092BF50", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(Ride other)
	{
		return default(bool);
	}

	[Token(Token = "0x60012BD")]
	[Address(RVA = "0xCD59C0", Offset = "0xCD4DC0", VA = "0x180CD59C0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60012BE")]
	[Address(RVA = "0xCD5AA0", Offset = "0xCD4EA0", VA = "0x180CD5AA0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60012BF")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60012C0")]
	[Address(RVA = "0x98A3B0", Offset = "0x9897B0", VA = "0x18098A3B0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60012C1")]
	[Address(RVA = "0xCD57D0", Offset = "0xCD4BD0", VA = "0x180CD57D0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60012C2")]
	[Address(RVA = "0x92C070", Offset = "0x92B470", VA = "0x18092C070", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(Ride other)
	{
	}

	[Token(Token = "0x60012C3")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60012C4")]
	[Address(RVA = "0x92C3A0", Offset = "0x92B7A0", VA = "0x18092C3A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
