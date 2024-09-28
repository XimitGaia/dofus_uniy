using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Teleportation;

[Token(Token = "0x2000071")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GroupTeleportPlayerAnswerRequest : IMessage<GroupTeleportPlayerAnswerRequest>, IMessage, IEquatable<GroupTeleportPlayerAnswerRequest>, IDeepCloneable<GroupTeleportPlayerAnswerRequest>, IBufferMessage
{
	[Token(Token = "0x4000165")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GroupTeleportPlayerAnswerRequest> _parser;

	[Token(Token = "0x4000166")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000167")]
	public const int AcceptFieldNumber = 1;

	[Token(Token = "0x4000168")]
	[FieldOffset(Offset = "0x18")]
	private bool accept_;

	[Token(Token = "0x170000CC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GroupTeleportPlayerAnswerRequest> Parser
	{
		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x951580", Offset = "0x950980", VA = "0x180951580")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000CD")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x9514D0", Offset = "0x9508D0", VA = "0x1809514D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000CE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x9516D0", Offset = "0x950AD0", VA = "0x1809516D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000CF")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Accept
	{
		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x60003D6")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GroupTeleportPlayerAnswerRequest()
	{
	}

	[Token(Token = "0x60003D7")]
	[Address(RVA = "0x951480", Offset = "0x950880", VA = "0x180951480")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GroupTeleportPlayerAnswerRequest(GroupTeleportPlayerAnswerRequest other)
	{
	}

	[Token(Token = "0x60003D8")]
	[Address(RVA = "0x9510F0", Offset = "0x9504F0", VA = "0x1809510F0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GroupTeleportPlayerAnswerRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60003DB")]
	[Address(RVA = "0x9511A0", Offset = "0x9505A0", VA = "0x1809511A0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60003DC")]
	[Address(RVA = "0x951170", Offset = "0x950570", VA = "0x180951170", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GroupTeleportPlayerAnswerRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60003DD")]
	[Address(RVA = "0x951230", Offset = "0x950630", VA = "0x180951230", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60003DE")]
	[Address(RVA = "0x951320", Offset = "0x950720", VA = "0x180951320", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60003DF")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60003E0")]
	[Address(RVA = "0x951670", Offset = "0x950A70", VA = "0x180951670", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60003E1")]
	[Address(RVA = "0x9510B0", Offset = "0x9504B0", VA = "0x1809510B0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60003E2")]
	[Address(RVA = "0x9512D0", Offset = "0x9506D0", VA = "0x1809512D0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(GroupTeleportPlayerAnswerRequest other)
	{
	}

	[Token(Token = "0x60003E3")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60003E4")]
	[Address(RVA = "0x9515D0", Offset = "0x9509D0", VA = "0x1809515D0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
