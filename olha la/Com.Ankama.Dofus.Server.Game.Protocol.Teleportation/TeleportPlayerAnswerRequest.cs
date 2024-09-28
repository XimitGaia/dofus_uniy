using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Teleportation;

[Token(Token = "0x200006F")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class TeleportPlayerAnswerRequest : IMessage<TeleportPlayerAnswerRequest>, IMessage, IEquatable<TeleportPlayerAnswerRequest>, IDeepCloneable<TeleportPlayerAnswerRequest>, IBufferMessage
{
	[Token(Token = "0x4000160")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<TeleportPlayerAnswerRequest> _parser;

	[Token(Token = "0x4000161")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000162")]
	public const int AcceptFieldNumber = 1;

	[Token(Token = "0x4000163")]
	[FieldOffset(Offset = "0x18")]
	private bool accept_;

	[Token(Token = "0x170000C8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TeleportPlayerAnswerRequest> Parser
	{
		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x9611B0", Offset = "0x9605B0", VA = "0x1809611B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000C9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x961100", Offset = "0x960500", VA = "0x180961100")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000CA")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x961200", Offset = "0x960600", VA = "0x180961200", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000CB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Accept
	{
		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x60003C0")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TeleportPlayerAnswerRequest()
	{
	}

	[Token(Token = "0x60003C1")]
	[Address(RVA = "0x951480", Offset = "0x950880", VA = "0x180951480")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TeleportPlayerAnswerRequest(TeleportPlayerAnswerRequest other)
	{
	}

	[Token(Token = "0x60003C2")]
	[Address(RVA = "0x960DF0", Offset = "0x9601F0", VA = "0x180960DF0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TeleportPlayerAnswerRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60003C5")]
	[Address(RVA = "0x960E70", Offset = "0x960270", VA = "0x180960E70", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60003C6")]
	[Address(RVA = "0x951170", Offset = "0x950570", VA = "0x180951170", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TeleportPlayerAnswerRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60003C7")]
	[Address(RVA = "0x960F00", Offset = "0x960300", VA = "0x180960F00", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60003C8")]
	[Address(RVA = "0x960FA0", Offset = "0x9603A0", VA = "0x180960FA0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60003C9")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60003CA")]
	[Address(RVA = "0x951670", Offset = "0x950A70", VA = "0x180951670", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60003CB")]
	[Address(RVA = "0x9510B0", Offset = "0x9504B0", VA = "0x1809510B0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60003CC")]
	[Address(RVA = "0x9512D0", Offset = "0x9506D0", VA = "0x1809512D0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TeleportPlayerAnswerRequest other)
	{
	}

	[Token(Token = "0x60003CD")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60003CE")]
	[Address(RVA = "0x9515D0", Offset = "0x9509D0", VA = "0x1809515D0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
