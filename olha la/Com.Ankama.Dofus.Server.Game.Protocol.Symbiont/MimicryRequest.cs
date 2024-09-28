using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Symbiont;

[Token(Token = "0x20000EA")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MimicryRequest : IMessage<MimicryRequest>, IMessage, IEquatable<MimicryRequest>, IDeepCloneable<MimicryRequest>, IBufferMessage
{
	[Token(Token = "0x400031A")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<MimicryRequest> _parser;

	[Token(Token = "0x400031B")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400031C")]
	public const int SymbiontUidFieldNumber = 1;

	[Token(Token = "0x400031D")]
	[FieldOffset(Offset = "0x18")]
	private int symbiontUid_;

	[Token(Token = "0x400031E")]
	public const int HostUidFieldNumber = 2;

	[Token(Token = "0x400031F")]
	[FieldOffset(Offset = "0x1C")]
	private int hostUid_;

	[Token(Token = "0x170001EB")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<MimicryRequest> Parser
	{
		[Token(Token = "0x6000911")]
		[Address(RVA = "0xA589D0", Offset = "0xA57DD0", VA = "0x180A589D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001EC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000912")]
		[Address(RVA = "0xA58920", Offset = "0xA57D20", VA = "0x180A58920")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001ED")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000913")]
		[Address(RVA = "0xA58A20", Offset = "0xA57E20", VA = "0x180A58A20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001EE")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int SymbiontUid
	{
		[Token(Token = "0x6000917")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000918")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170001EF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int HostUid
	{
		[Token(Token = "0x6000919")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600091A")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x6000914")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MimicryRequest()
	{
	}

	[Token(Token = "0x6000915")]
	[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MimicryRequest(MimicryRequest other)
	{
	}

	[Token(Token = "0x6000916")]
	[Address(RVA = "0xA586A0", Offset = "0xA57AA0", VA = "0x180A586A0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MimicryRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x600091B")]
	[Address(RVA = "0xA58730", Offset = "0xA57B30", VA = "0x180A58730", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600091C")]
	[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(MimicryRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x600091D")]
	[Address(RVA = "0x9691C0", Offset = "0x9685C0", VA = "0x1809691C0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600091E")]
	[Address(RVA = "0xA587C0", Offset = "0xA57BC0", VA = "0x180A587C0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600091F")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000920")]
	[Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000921")]
	[Address(RVA = "0xA585E0", Offset = "0xA579E0", VA = "0x180A585E0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000922")]
	[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MimicryRequest other)
	{
	}

	[Token(Token = "0x6000923")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000924")]
	[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
