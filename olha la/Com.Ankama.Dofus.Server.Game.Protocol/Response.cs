using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol;

[Token(Token = "0x2000013")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class Response : IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IBufferMessage
{
	[Token(Token = "0x400003D")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<Response> _parser;

	[Token(Token = "0x400003E")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400003F")]
	public const int UidFieldNumber = 1;

	[Token(Token = "0x4000040")]
	[FieldOffset(Offset = "0x18")]
	private int uid_;

	[Token(Token = "0x4000041")]
	public const int ContentFieldNumber = 2;

	[Token(Token = "0x4000042")]
	[FieldOffset(Offset = "0x20")]
	private Any content_;

	[Token(Token = "0x1700001A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<Response> Parser
	{
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x9414E0", Offset = "0x9408E0", VA = "0x1809414E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700001B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x941430", Offset = "0x940830", VA = "0x180941430")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700001C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x941650", Offset = "0x940A50", VA = "0x180941650", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700001D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Uid
	{
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x1700001E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Any Content
	{
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000077")]
		[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
		set
		{
		}
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Response()
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x940C00", Offset = "0x940000", VA = "0x180940C00")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Response(Response other)
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x9410B0", Offset = "0x9404B0", VA = "0x1809410B0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Response Clone()
	{
		return null;
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x941150", Offset = "0x940550", VA = "0x180941150", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x940820", Offset = "0x93FC20", VA = "0x180940820", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(Response other)
	{
		return default(bool);
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x940940", Offset = "0x93FD40", VA = "0x180940940", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x9412D0", Offset = "0x9406D0", VA = "0x1809412D0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x940E90", Offset = "0x940290", VA = "0x180940E90", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x940FF0", Offset = "0x9403F0", VA = "0x180940FF0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x941200", Offset = "0x940600", VA = "0x180941200", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(Response other)
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x941530", Offset = "0x940930", VA = "0x180941530", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
