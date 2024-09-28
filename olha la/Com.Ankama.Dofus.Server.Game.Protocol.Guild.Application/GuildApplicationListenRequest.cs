using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Application;

[Token(Token = "0x20004FA")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildApplicationListenRequest : IMessage<GuildApplicationListenRequest>, IMessage, IEquatable<GuildApplicationListenRequest>, IDeepCloneable<GuildApplicationListenRequest>, IBufferMessage
{
	[Token(Token = "0x40010FB")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildApplicationListenRequest> _parser;

	[Token(Token = "0x40010FC")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40010FD")]
	public const int ListenFieldNumber = 1;

	[Token(Token = "0x40010FE")]
	[FieldOffset(Offset = "0x18")]
	private bool listen_;

	[Token(Token = "0x17000B2D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<GuildApplicationListenRequest> Parser
	{
		[Token(Token = "0x60034A1")]
		[Address(RVA = "0x9E40A0", Offset = "0x9E34A0", VA = "0x1809E40A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B2E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60034A2")]
		[Address(RVA = "0x9E3FF0", Offset = "0x9E33F0", VA = "0x1809E3FF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B2F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60034A3")]
		[Address(RVA = "0x9E40F0", Offset = "0x9E34F0", VA = "0x1809E40F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B30")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Listen
	{
		[Token(Token = "0x60034A7")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60034A8")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x60034A4")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildApplicationListenRequest()
	{
	}

	[Token(Token = "0x60034A5")]
	[Address(RVA = "0x951480", Offset = "0x950880", VA = "0x180951480")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildApplicationListenRequest(GuildApplicationListenRequest other)
	{
	}

	[Token(Token = "0x60034A6")]
	[Address(RVA = "0x9E3CE0", Offset = "0x9E30E0", VA = "0x1809E3CE0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildApplicationListenRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60034A9")]
	[Address(RVA = "0x9E3D60", Offset = "0x9E3160", VA = "0x1809E3D60", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60034AA")]
	[Address(RVA = "0x951170", Offset = "0x950570", VA = "0x180951170", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(GuildApplicationListenRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60034AB")]
	[Address(RVA = "0x9E3DF0", Offset = "0x9E31F0", VA = "0x1809E3DF0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60034AC")]
	[Address(RVA = "0x9E3E90", Offset = "0x9E3290", VA = "0x1809E3E90", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60034AD")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60034AE")]
	[Address(RVA = "0x951670", Offset = "0x950A70", VA = "0x180951670", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60034AF")]
	[Address(RVA = "0x9510B0", Offset = "0x9504B0", VA = "0x1809510B0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60034B0")]
	[Address(RVA = "0x9512D0", Offset = "0x9506D0", VA = "0x1809512D0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildApplicationListenRequest other)
	{
	}

	[Token(Token = "0x60034B1")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60034B2")]
	[Address(RVA = "0x9515D0", Offset = "0x9509D0", VA = "0x1809515D0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
