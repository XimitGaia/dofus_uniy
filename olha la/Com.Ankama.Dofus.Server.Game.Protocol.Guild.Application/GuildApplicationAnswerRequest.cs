using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Application;

[Token(Token = "0x2000500")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildApplicationAnswerRequest : IMessage<GuildApplicationAnswerRequest>, IMessage, IEquatable<GuildApplicationAnswerRequest>, IDeepCloneable<GuildApplicationAnswerRequest>, IBufferMessage
{
	[Token(Token = "0x400110A")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildApplicationAnswerRequest> _parser;

	[Token(Token = "0x400110B")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400110C")]
	public const int AcceptedFieldNumber = 1;

	[Token(Token = "0x400110D")]
	[FieldOffset(Offset = "0x18")]
	private bool accepted_;

	[Token(Token = "0x400110E")]
	public const int PlayerIdFieldNumber = 2;

	[Token(Token = "0x400110F")]
	[FieldOffset(Offset = "0x20")]
	private long playerId_;

	[Token(Token = "0x17000B39")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuildApplicationAnswerRequest> Parser
	{
		[Token(Token = "0x60034E3")]
		[Address(RVA = "0x9E2E40", Offset = "0x9E2240", VA = "0x1809E2E40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B3A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60034E4")]
		[Address(RVA = "0x9E2D90", Offset = "0x9E2190", VA = "0x1809E2D90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B3B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60034E5")]
		[Address(RVA = "0x9E2E90", Offset = "0x9E2290", VA = "0x1809E2E90", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B3C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Accepted
	{
		[Token(Token = "0x60034E9")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60034EA")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x17000B3D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long PlayerId
	{
		[Token(Token = "0x60034EB")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60034EC")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x60034E6")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildApplicationAnswerRequest()
	{
	}

	[Token(Token = "0x60034E7")]
	[Address(RVA = "0x9D42F0", Offset = "0x9D36F0", VA = "0x1809D42F0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildApplicationAnswerRequest(GuildApplicationAnswerRequest other)
	{
	}

	[Token(Token = "0x60034E8")]
	[Address(RVA = "0x9E2A30", Offset = "0x9E1E30", VA = "0x1809E2A30", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildApplicationAnswerRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60034ED")]
	[Address(RVA = "0x9E2AC0", Offset = "0x9E1EC0", VA = "0x1809E2AC0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60034EE")]
	[Address(RVA = "0x9D3F80", Offset = "0x9D3380", VA = "0x1809D3F80", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildApplicationAnswerRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60034EF")]
	[Address(RVA = "0x9E2B60", Offset = "0x9E1F60", VA = "0x1809E2B60", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60034F0")]
	[Address(RVA = "0x9E2C30", Offset = "0x9E2030", VA = "0x1809E2C30", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60034F1")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60034F2")]
	[Address(RVA = "0x9D4510", Offset = "0x9D3910", VA = "0x1809D4510", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60034F3")]
	[Address(RVA = "0x9E2990", Offset = "0x9E1D90", VA = "0x1809E2990", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60034F4")]
	[Address(RVA = "0x9D4130", Offset = "0x9D3530", VA = "0x1809D4130", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildApplicationAnswerRequest other)
	{
	}

	[Token(Token = "0x60034F5")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60034F6")]
	[Address(RVA = "0x9D4450", Offset = "0x9D3850", VA = "0x1809D4450", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
