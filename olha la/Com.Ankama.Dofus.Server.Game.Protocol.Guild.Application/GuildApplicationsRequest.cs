using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Application;

[Token(Token = "0x20004FE")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildApplicationsRequest : IMessage<GuildApplicationsRequest>, IMessage, IEquatable<GuildApplicationsRequest>, IDeepCloneable<GuildApplicationsRequest>, IBufferMessage
{
	[Token(Token = "0x4001103")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildApplicationsRequest> _parser;

	[Token(Token = "0x4001104")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001105")]
	public const int OffsetFieldNumber = 1;

	[Token(Token = "0x4001106")]
	[FieldOffset(Offset = "0x18")]
	private long offset_;

	[Token(Token = "0x4001107")]
	public const int CountFieldNumber = 2;

	[Token(Token = "0x4001108")]
	[FieldOffset(Offset = "0x20")]
	private int count_;

	[Token(Token = "0x17000B34")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<GuildApplicationsRequest> Parser
	{
		[Token(Token = "0x60034CB")]
		[Address(RVA = "0x9E94D0", Offset = "0x9E88D0", VA = "0x1809E94D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B35")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60034CC")]
		[Address(RVA = "0x9E9420", Offset = "0x9E8820", VA = "0x1809E9420")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B36")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60034CD")]
		[Address(RVA = "0x9E95A0", Offset = "0x9E89A0", VA = "0x1809E95A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B37")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long Offset
	{
		[Token(Token = "0x60034D1")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60034D2")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x17000B38")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Count
	{
		[Token(Token = "0x60034D3")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60034D4")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x60034CE")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildApplicationsRequest()
	{
	}

	[Token(Token = "0x60034CF")]
	[Address(RVA = "0x948CF0", Offset = "0x9480F0", VA = "0x180948CF0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildApplicationsRequest(GuildApplicationsRequest other)
	{
	}

	[Token(Token = "0x60034D0")]
	[Address(RVA = "0x9E9190", Offset = "0x9E8590", VA = "0x1809E9190", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildApplicationsRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60034D5")]
	[Address(RVA = "0x9E9220", Offset = "0x9E8620", VA = "0x1809E9220", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60034D6")]
	[Address(RVA = "0x9489C0", Offset = "0x947DC0", VA = "0x1809489C0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildApplicationsRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60034D7")]
	[Address(RVA = "0x948AA0", Offset = "0x947EA0", VA = "0x180948AA0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60034D8")]
	[Address(RVA = "0x9E92C0", Offset = "0x9E86C0", VA = "0x1809E92C0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60034D9")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60034DA")]
	[Address(RVA = "0x9E9520", Offset = "0x9E8920", VA = "0x1809E9520", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60034DB")]
	[Address(RVA = "0x9E90D0", Offset = "0x9E84D0", VA = "0x1809E90D0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60034DC")]
	[Address(RVA = "0x948B30", Offset = "0x947F30", VA = "0x180948B30", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(GuildApplicationsRequest other)
	{
	}

	[Token(Token = "0x60034DD")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60034DE")]
	[Address(RVA = "0x948E20", Offset = "0x948220", VA = "0x180948E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
