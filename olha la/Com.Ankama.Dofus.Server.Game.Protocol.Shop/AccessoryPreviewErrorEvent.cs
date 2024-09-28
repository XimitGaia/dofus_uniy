using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Shop;

[Token(Token = "0x2000146")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AccessoryPreviewErrorEvent : IMessage<AccessoryPreviewErrorEvent>, IMessage, IEquatable<AccessoryPreviewErrorEvent>, IDeepCloneable<AccessoryPreviewErrorEvent>, IBufferMessage
{
	[Token(Token = "0x2000147")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x2000148")]
		public enum AccessoryPreviewError
		{
			[Token(Token = "0x4000463")]
			[OriginalName("ERROR")]
			Error,
			[Token(Token = "0x4000464")]
			[OriginalName("COOL_DOWN")]
			CoolDown,
			[Token(Token = "0x4000465")]
			[OriginalName("BAD_ITEM")]
			BadItem
		}
	}

	[Token(Token = "0x400045E")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AccessoryPreviewErrorEvent> _parser;

	[Token(Token = "0x400045F")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000460")]
	public const int ErrorFieldNumber = 1;

	[Token(Token = "0x4000461")]
	[FieldOffset(Offset = "0x18")]
	private Types.AccessoryPreviewError error_;

	[Token(Token = "0x170002B8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AccessoryPreviewErrorEvent> Parser
	{
		[Token(Token = "0x6000CB6")]
		[Address(RVA = "0xB61E70", Offset = "0xB61270", VA = "0x180B61E70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002B9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000CB7")]
		[Address(RVA = "0xB61DC0", Offset = "0xB611C0", VA = "0x180B61DC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002BA")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000CB8")]
		[Address(RVA = "0xB61EC0", Offset = "0xB612C0", VA = "0x180B61EC0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002BB")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.AccessoryPreviewError Error
	{
		[Token(Token = "0x6000CBC")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(Types.AccessoryPreviewError);
		}
		[Token(Token = "0x6000CBD")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6000CB9")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AccessoryPreviewErrorEvent()
	{
	}

	[Token(Token = "0x6000CBA")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AccessoryPreviewErrorEvent(AccessoryPreviewErrorEvent other)
	{
	}

	[Token(Token = "0x6000CBB")]
	[Address(RVA = "0xB61B50", Offset = "0xB60F50", VA = "0x180B61B50", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AccessoryPreviewErrorEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6000CBE")]
	[Address(RVA = "0xB61BD0", Offset = "0xB60FD0", VA = "0x180B61BD0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000CBF")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AccessoryPreviewErrorEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000CC0")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000CC1")]
	[Address(RVA = "0xB61C60", Offset = "0xB61060", VA = "0x180B61C60", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000CC2")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000CC3")]
	[Address(RVA = "0x934790", Offset = "0x933B90", VA = "0x180934790", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000CC4")]
	[Address(RVA = "0xB61AC0", Offset = "0xB60EC0", VA = "0x180B61AC0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000CC5")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AccessoryPreviewErrorEvent other)
	{
	}

	[Token(Token = "0x6000CC6")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000CC7")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
