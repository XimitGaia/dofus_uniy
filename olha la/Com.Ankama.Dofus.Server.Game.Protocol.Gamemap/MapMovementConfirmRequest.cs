using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Gamemap;

[Token(Token = "0x200051A")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MapMovementConfirmRequest : IMessage<MapMovementConfirmRequest>, IMessage, IEquatable<MapMovementConfirmRequest>, IDeepCloneable<MapMovementConfirmRequest>, IBufferMessage
{
	[Token(Token = "0x400115D")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<MapMovementConfirmRequest> _parser;

	[Token(Token = "0x400115E")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17000B74")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<MapMovementConfirmRequest> Parser
	{
		[Token(Token = "0x60035FF")]
		[Address(RVA = "0xA09350", Offset = "0xA08750", VA = "0x180A09350")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B75")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6003600")]
		[Address(RVA = "0xA092A0", Offset = "0xA086A0", VA = "0x180A092A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B76")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6003601")]
		[Address(RVA = "0xA093A0", Offset = "0xA087A0", VA = "0x180A093A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003602")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapMovementConfirmRequest()
	{
	}

	[Token(Token = "0x6003603")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapMovementConfirmRequest(MapMovementConfirmRequest other)
	{
	}

	[Token(Token = "0x6003604")]
	[Address(RVA = "0xA09040", Offset = "0xA08440", VA = "0x180A09040", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapMovementConfirmRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6003605")]
	[Address(RVA = "0xA090C0", Offset = "0xA084C0", VA = "0x180A090C0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003606")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MapMovementConfirmRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003607")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6003608")]
	[Address(RVA = "0xA09140", Offset = "0xA08540", VA = "0x180A09140", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6003609")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600360A")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600360B")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600360C")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MapMovementConfirmRequest other)
	{
	}

	[Token(Token = "0x600360D")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600360E")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
