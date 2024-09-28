using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Breach;

[Token(Token = "0x20008F1")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class BreachInvitationRequest : IMessage<BreachInvitationRequest>, IMessage, IEquatable<BreachInvitationRequest>, IDeepCloneable<BreachInvitationRequest>, IBufferMessage
{
	[Token(Token = "0x4001EA8")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<BreachInvitationRequest> _parser;

	[Token(Token = "0x4001EA9")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001EAA")]
	public const int GuestsFieldNumber = 1;

	[Token(Token = "0x4001EAB")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<long> _repeated_guests_codec;

	[Token(Token = "0x4001EAC")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<long> guests_;

	[Token(Token = "0x1700140A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<BreachInvitationRequest> Parser
	{
		[Token(Token = "0x6005E9A")]
		[Address(RVA = "0xB51DC0", Offset = "0xB511C0", VA = "0x180B51DC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700140B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005E9B")]
		[Address(RVA = "0xB51D10", Offset = "0xB51110", VA = "0x180B51D10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700140C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005E9C")]
		[Address(RVA = "0xB51FE0", Offset = "0xB513E0", VA = "0x180B51FE0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700140D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<long> Guests
	{
		[Token(Token = "0x6005EA0")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005E9D")]
	[Address(RVA = "0xB51C90", Offset = "0xB51090", VA = "0x180B51C90")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BreachInvitationRequest()
	{
	}

	[Token(Token = "0x6005E9E")]
	[Address(RVA = "0xB51C00", Offset = "0xB51000", VA = "0x180B51C00")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BreachInvitationRequest(BreachInvitationRequest other)
	{
	}

	[Token(Token = "0x6005E9F")]
	[Address(RVA = "0xB517C0", Offset = "0xB50BC0", VA = "0x180B517C0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public BreachInvitationRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6005EA1")]
	[Address(RVA = "0xB51910", Offset = "0xB50D10", VA = "0x180B51910", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005EA2")]
	[Address(RVA = "0xB51880", Offset = "0xB50C80", VA = "0x180B51880", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(BreachInvitationRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005EA3")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005EA4")]
	[Address(RVA = "0xB51A70", Offset = "0xB50E70", VA = "0x180B51A70", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005EA5")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005EA6")]
	[Address(RVA = "0xB51F30", Offset = "0xB51330", VA = "0x180B51F30", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005EA7")]
	[Address(RVA = "0xB51720", Offset = "0xB50B20", VA = "0x180B51720", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005EA8")]
	[Address(RVA = "0xB519F0", Offset = "0xB50DF0", VA = "0x180B519F0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BreachInvitationRequest other)
	{
	}

	[Token(Token = "0x6005EA9")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005EAA")]
	[Address(RVA = "0xB51E10", Offset = "0xB51210", VA = "0x180B51E10", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
