using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Breach;

[Token(Token = "0x20008F3")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class BreachInvitationAnswerRequest : IMessage<BreachInvitationAnswerRequest>, IMessage, IEquatable<BreachInvitationAnswerRequest>, IDeepCloneable<BreachInvitationAnswerRequest>, IBufferMessage
{
	[Token(Token = "0x4001EAE")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<BreachInvitationAnswerRequest> _parser;

	[Token(Token = "0x4001EAF")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001EB0")]
	public const int AcceptedFieldNumber = 1;

	[Token(Token = "0x4001EB1")]
	[FieldOffset(Offset = "0x18")]
	private bool accepted_;

	[Token(Token = "0x1700140E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<BreachInvitationAnswerRequest> Parser
	{
		[Token(Token = "0x6005EAF")]
		[Address(RVA = "0xB50730", Offset = "0xB4FB30", VA = "0x180B50730")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700140F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005EB0")]
		[Address(RVA = "0xB50680", Offset = "0xB4FA80", VA = "0x180B50680")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001410")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005EB1")]
		[Address(RVA = "0xB50780", Offset = "0xB4FB80", VA = "0x180B50780", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001411")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Accepted
	{
		[Token(Token = "0x6005EB5")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6005EB6")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x6005EB2")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BreachInvitationAnswerRequest()
	{
	}

	[Token(Token = "0x6005EB3")]
	[Address(RVA = "0x951480", Offset = "0x950880", VA = "0x180951480")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public BreachInvitationAnswerRequest(BreachInvitationAnswerRequest other)
	{
	}

	[Token(Token = "0x6005EB4")]
	[Address(RVA = "0xB50370", Offset = "0xB4F770", VA = "0x180B50370", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public BreachInvitationAnswerRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6005EB7")]
	[Address(RVA = "0xB503F0", Offset = "0xB4F7F0", VA = "0x180B503F0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005EB8")]
	[Address(RVA = "0x951170", Offset = "0x950570", VA = "0x180951170", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BreachInvitationAnswerRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005EB9")]
	[Address(RVA = "0xB50480", Offset = "0xB4F880", VA = "0x180B50480", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005EBA")]
	[Address(RVA = "0xB50520", Offset = "0xB4F920", VA = "0x180B50520", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005EBB")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005EBC")]
	[Address(RVA = "0x951670", Offset = "0x950A70", VA = "0x180951670", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005EBD")]
	[Address(RVA = "0x9510B0", Offset = "0x9504B0", VA = "0x1809510B0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005EBE")]
	[Address(RVA = "0x9512D0", Offset = "0x9506D0", VA = "0x1809512D0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BreachInvitationAnswerRequest other)
	{
	}

	[Token(Token = "0x6005EBF")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005EC0")]
	[Address(RVA = "0x9515D0", Offset = "0x9509D0", VA = "0x1809515D0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
