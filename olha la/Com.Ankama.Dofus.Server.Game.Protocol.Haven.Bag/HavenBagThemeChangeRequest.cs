using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Haven.Bag;

[Token(Token = "0x2000423")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class HavenBagThemeChangeRequest : IMessage<HavenBagThemeChangeRequest>, IMessage, IEquatable<HavenBagThemeChangeRequest>, IDeepCloneable<HavenBagThemeChangeRequest>, IBufferMessage
{
	[Token(Token = "0x4000E68")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<HavenBagThemeChangeRequest> _parser;

	[Token(Token = "0x4000E69")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000E6A")]
	public const int ThemeFieldNumber = 1;

	[Token(Token = "0x4000E6B")]
	[FieldOffset(Offset = "0x18")]
	private int theme_;

	[Token(Token = "0x1700095F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HavenBagThemeChangeRequest> Parser
	{
		[Token(Token = "0x6002BAD")]
		[Address(RVA = "0x9C3DD0", Offset = "0x9C31D0", VA = "0x1809C3DD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000960")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002BAE")]
		[Address(RVA = "0x9C3D20", Offset = "0x9C3120", VA = "0x1809C3D20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000961")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002BAF")]
		[Address(RVA = "0x9C3E20", Offset = "0x9C3220", VA = "0x1809C3E20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000962")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Theme
	{
		[Token(Token = "0x6002BB3")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002BB4")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6002BB0")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public HavenBagThemeChangeRequest()
	{
	}

	[Token(Token = "0x6002BB1")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HavenBagThemeChangeRequest(HavenBagThemeChangeRequest other)
	{
	}

	[Token(Token = "0x6002BB2")]
	[Address(RVA = "0x9C3AB0", Offset = "0x9C2EB0", VA = "0x1809C3AB0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public HavenBagThemeChangeRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6002BB5")]
	[Address(RVA = "0x9C3B30", Offset = "0x9C2F30", VA = "0x1809C3B30", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002BB6")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HavenBagThemeChangeRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002BB7")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002BB8")]
	[Address(RVA = "0x9C3BC0", Offset = "0x9C2FC0", VA = "0x1809C3BC0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002BB9")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002BBA")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002BBB")]
	[Address(RVA = "0x9C3A20", Offset = "0x9C2E20", VA = "0x1809C3A20", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002BBC")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(HavenBagThemeChangeRequest other)
	{
	}

	[Token(Token = "0x6002BBD")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002BBE")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
