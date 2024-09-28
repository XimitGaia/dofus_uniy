using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic;

[Token(Token = "0x2000C23")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class OutfitRemoveRequest : IMessage<OutfitRemoveRequest>, IMessage, IEquatable<OutfitRemoveRequest>, IDeepCloneable<OutfitRemoveRequest>, IBufferMessage
{
	[Token(Token = "0x4002D06")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<OutfitRemoveRequest> _parser;

	[Token(Token = "0x4002D07")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002D08")]
	public const int OutfitUuidFieldNumber = 1;

	[Token(Token = "0x4002D09")]
	[FieldOffset(Offset = "0x18")]
	private string outfitUuid_;

	[Token(Token = "0x17001C04")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<OutfitRemoveRequest> Parser
	{
		[Token(Token = "0x6007FAF")]
		[Address(RVA = "0xC68600", Offset = "0xC67A00", VA = "0x180C68600")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C05")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007FB0")]
		[Address(RVA = "0xC68550", Offset = "0xC67950", VA = "0x180C68550")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C06")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007FB1")]
		[Address(RVA = "0xC68710", Offset = "0xC67B10", VA = "0x180C68710", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C07")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string OutfitUuid
	{
		[Token(Token = "0x6007FB5")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007FB6")]
		[Address(RVA = "0xC687F0", Offset = "0xC67BF0", VA = "0x180C687F0")]
		set
		{
		}
	}

	[Token(Token = "0x6007FB2")]
	[Address(RVA = "0xC68500", Offset = "0xC67900", VA = "0x180C68500")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OutfitRemoveRequest()
	{
	}

	[Token(Token = "0x6007FB3")]
	[Address(RVA = "0xC68460", Offset = "0xC67860", VA = "0x180C68460")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OutfitRemoveRequest(OutfitRemoveRequest other)
	{
	}

	[Token(Token = "0x6007FB4")]
	[Address(RVA = "0xC68120", Offset = "0xC67520", VA = "0x180C68120", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OutfitRemoveRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6007FB7")]
	[Address(RVA = "0xC681F0", Offset = "0xC675F0", VA = "0x180C681F0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007FB8")]
	[Address(RVA = "0x91CE00", Offset = "0x91C200", VA = "0x18091CE00", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OutfitRemoveRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007FB9")]
	[Address(RVA = "0x91CF20", Offset = "0x91C320", VA = "0x18091CF20", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007FBA")]
	[Address(RVA = "0xC68300", Offset = "0xC67700", VA = "0x180C68300", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007FBB")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007FBC")]
	[Address(RVA = "0x91D400", Offset = "0x91C800", VA = "0x18091D400", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007FBD")]
	[Address(RVA = "0xC68090", Offset = "0xC67490", VA = "0x180C68090", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007FBE")]
	[Address(RVA = "0xC682A0", Offset = "0xC676A0", VA = "0x180C682A0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OutfitRemoveRequest other)
	{
	}

	[Token(Token = "0x6007FBF")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007FC0")]
	[Address(RVA = "0xC68650", Offset = "0xC67A50", VA = "0x180C68650", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
