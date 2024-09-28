using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Information;

[Token(Token = "0x2000CC6")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceMotdSetRequest : IMessage<AllianceMotdSetRequest>, IMessage, IEquatable<AllianceMotdSetRequest>, IDeepCloneable<AllianceMotdSetRequest>, IBufferMessage
{
	[Token(Token = "0x4002F24")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceMotdSetRequest> _parser;

	[Token(Token = "0x4002F25")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002F26")]
	public const int ContentFieldNumber = 1;

	[Token(Token = "0x4002F27")]
	[FieldOffset(Offset = "0x18")]
	private string content_;

	[Token(Token = "0x17001D76")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AllianceMotdSetRequest> Parser
	{
		[Token(Token = "0x600869C")]
		[Address(RVA = "0xC9B410", Offset = "0xC9A810", VA = "0x180C9B410")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D77")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600869D")]
		[Address(RVA = "0xC9B360", Offset = "0xC9A760", VA = "0x180C9B360")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D78")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600869E")]
		[Address(RVA = "0xC9B520", Offset = "0xC9A920", VA = "0x180C9B520", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D79")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string Content
	{
		[Token(Token = "0x60086A2")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x60086A3")]
		[Address(RVA = "0xC9B600", Offset = "0xC9AA00", VA = "0x180C9B600")]
		set
		{
		}
	}

	[Token(Token = "0x600869F")]
	[Address(RVA = "0xC9B270", Offset = "0xC9A670", VA = "0x180C9B270")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceMotdSetRequest()
	{
	}

	[Token(Token = "0x60086A0")]
	[Address(RVA = "0xC9B2C0", Offset = "0xC9A6C0", VA = "0x180C9B2C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceMotdSetRequest(AllianceMotdSetRequest other)
	{
	}

	[Token(Token = "0x60086A1")]
	[Address(RVA = "0xC9AF30", Offset = "0xC9A330", VA = "0x180C9AF30", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceMotdSetRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60086A4")]
	[Address(RVA = "0xC9B000", Offset = "0xC9A400", VA = "0x180C9B000", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60086A5")]
	[Address(RVA = "0x91CE00", Offset = "0x91C200", VA = "0x18091CE00", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AllianceMotdSetRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60086A6")]
	[Address(RVA = "0x91CF20", Offset = "0x91C320", VA = "0x18091CF20", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60086A7")]
	[Address(RVA = "0xC9B110", Offset = "0xC9A510", VA = "0x180C9B110", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60086A8")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60086A9")]
	[Address(RVA = "0x91D400", Offset = "0x91C800", VA = "0x18091D400", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60086AA")]
	[Address(RVA = "0xC9AEA0", Offset = "0xC9A2A0", VA = "0x180C9AEA0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60086AB")]
	[Address(RVA = "0xC9B0B0", Offset = "0xC9A4B0", VA = "0x180C9B0B0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AllianceMotdSetRequest other)
	{
	}

	[Token(Token = "0x60086AC")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60086AD")]
	[Address(RVA = "0xC9B460", Offset = "0xC9A860", VA = "0x180C9B460", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
