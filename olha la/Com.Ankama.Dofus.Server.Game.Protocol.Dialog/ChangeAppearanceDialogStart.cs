using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Dialog;

[Token(Token = "0x2000762")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChangeAppearanceDialogStart : IMessage<ChangeAppearanceDialogStart>, IMessage, IEquatable<ChangeAppearanceDialogStart>, IDeepCloneable<ChangeAppearanceDialogStart>, IBufferMessage
{
	[Token(Token = "0x2000763")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x2000764")]
		public enum AppearanceType
		{
			[Token(Token = "0x40019E7")]
			[OriginalName("BODY")]
			Body,
			[Token(Token = "0x40019E8")]
			[OriginalName("FACE")]
			Face,
			[Token(Token = "0x40019E9")]
			[OriginalName("COLORS")]
			Colors
		}
	}

	[Token(Token = "0x40019E2")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ChangeAppearanceDialogStart> _parser;

	[Token(Token = "0x40019E3")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40019E4")]
	public const int TypeFieldNumber = 1;

	[Token(Token = "0x40019E5")]
	[FieldOffset(Offset = "0x18")]
	private Types.AppearanceType type_;

	[Token(Token = "0x170010E8")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ChangeAppearanceDialogStart> Parser
	{
		[Token(Token = "0x6004F04")]
		[Address(RVA = "0xACA010", Offset = "0xAC9410", VA = "0x180ACA010")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010E9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004F05")]
		[Address(RVA = "0xAC9F60", Offset = "0xAC9360", VA = "0x180AC9F60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010EA")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004F06")]
		[Address(RVA = "0xACA060", Offset = "0xAC9460", VA = "0x180ACA060", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010EB")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.AppearanceType Type
	{
		[Token(Token = "0x6004F0A")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(Types.AppearanceType);
		}
		[Token(Token = "0x6004F0B")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6004F07")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ChangeAppearanceDialogStart()
	{
	}

	[Token(Token = "0x6004F08")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChangeAppearanceDialogStart(ChangeAppearanceDialogStart other)
	{
	}

	[Token(Token = "0x6004F09")]
	[Address(RVA = "0xAC9CF0", Offset = "0xAC90F0", VA = "0x180AC9CF0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ChangeAppearanceDialogStart Clone()
	{
		return null;
	}

	[Token(Token = "0x6004F0C")]
	[Address(RVA = "0xAC9D70", Offset = "0xAC9170", VA = "0x180AC9D70", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004F0D")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChangeAppearanceDialogStart other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004F0E")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004F0F")]
	[Address(RVA = "0xAC9E00", Offset = "0xAC9200", VA = "0x180AC9E00", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004F10")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004F11")]
	[Address(RVA = "0x934790", Offset = "0x933B90", VA = "0x180934790", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004F12")]
	[Address(RVA = "0xAC9C60", Offset = "0xAC9060", VA = "0x180AC9C60", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004F13")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChangeAppearanceDialogStart other)
	{
	}

	[Token(Token = "0x6004F14")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004F15")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
