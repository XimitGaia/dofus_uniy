using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Information;

[Token(Token = "0x2000CCC")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceBulletinSetRequest : IMessage<AllianceBulletinSetRequest>, IMessage, IEquatable<AllianceBulletinSetRequest>, IDeepCloneable<AllianceBulletinSetRequest>, IBufferMessage
{
	[Token(Token = "0x4002F33")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceBulletinSetRequest> _parser;

	[Token(Token = "0x4002F34")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002F35")]
	public const int ContentFieldNumber = 1;

	[Token(Token = "0x4002F36")]
	[FieldOffset(Offset = "0x18")]
	private string content_;

	[Token(Token = "0x17001D82")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AllianceBulletinSetRequest> Parser
	{
		[Token(Token = "0x60086DE")]
		[Address(RVA = "0xC88ED0", Offset = "0xC882D0", VA = "0x180C88ED0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D83")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60086DF")]
		[Address(RVA = "0xC88E20", Offset = "0xC88220", VA = "0x180C88E20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D84")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60086E0")]
		[Address(RVA = "0xC88FE0", Offset = "0xC883E0", VA = "0x180C88FE0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D85")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string Content
	{
		[Token(Token = "0x60086E4")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x60086E5")]
		[Address(RVA = "0xC890C0", Offset = "0xC884C0", VA = "0x180C890C0")]
		set
		{
		}
	}

	[Token(Token = "0x60086E1")]
	[Address(RVA = "0xC88D30", Offset = "0xC88130", VA = "0x180C88D30")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceBulletinSetRequest()
	{
	}

	[Token(Token = "0x60086E2")]
	[Address(RVA = "0xC88D80", Offset = "0xC88180", VA = "0x180C88D80")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceBulletinSetRequest(AllianceBulletinSetRequest other)
	{
	}

	[Token(Token = "0x60086E3")]
	[Address(RVA = "0xC889F0", Offset = "0xC87DF0", VA = "0x180C889F0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceBulletinSetRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60086E6")]
	[Address(RVA = "0xC88AC0", Offset = "0xC87EC0", VA = "0x180C88AC0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60086E7")]
	[Address(RVA = "0x91CE00", Offset = "0x91C200", VA = "0x18091CE00", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AllianceBulletinSetRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60086E8")]
	[Address(RVA = "0x91CF20", Offset = "0x91C320", VA = "0x18091CF20", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60086E9")]
	[Address(RVA = "0xC88BD0", Offset = "0xC87FD0", VA = "0x180C88BD0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60086EA")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60086EB")]
	[Address(RVA = "0x91D400", Offset = "0x91C800", VA = "0x18091D400", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60086EC")]
	[Address(RVA = "0xC88960", Offset = "0xC87D60", VA = "0x180C88960", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60086ED")]
	[Address(RVA = "0xC88B70", Offset = "0xC87F70", VA = "0x180C88B70", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(AllianceBulletinSetRequest other)
	{
	}

	[Token(Token = "0x60086EE")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60086EF")]
	[Address(RVA = "0xC88F20", Offset = "0xC88320", VA = "0x180C88F20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
