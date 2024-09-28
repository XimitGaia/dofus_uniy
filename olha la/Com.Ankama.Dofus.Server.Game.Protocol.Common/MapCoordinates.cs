using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000ABD")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MapCoordinates : IMessage<MapCoordinates>, IMessage, IEquatable<MapCoordinates>, IDeepCloneable<MapCoordinates>, IBufferMessage
{
	[Token(Token = "0x4002748")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<MapCoordinates> _parser;

	[Token(Token = "0x4002749")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400274A")]
	public const int WorldXFieldNumber = 1;

	[Token(Token = "0x400274B")]
	[FieldOffset(Offset = "0x18")]
	private int worldX_;

	[Token(Token = "0x400274C")]
	public const int WorldYFieldNumber = 2;

	[Token(Token = "0x400274D")]
	[FieldOffset(Offset = "0x1C")]
	private int worldY_;

	[Token(Token = "0x17001883")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<MapCoordinates> Parser
	{
		[Token(Token = "0x6007072")]
		[Address(RVA = "0xBE2C90", Offset = "0xBE2090", VA = "0x180BE2C90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001884")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007073")]
		[Address(RVA = "0xBE2BE0", Offset = "0xBE1FE0", VA = "0x180BE2BE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001885")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007074")]
		[Address(RVA = "0xBE2CE0", Offset = "0xBE20E0", VA = "0x180BE2CE0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001886")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int WorldX
	{
		[Token(Token = "0x6007078")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007079")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17001887")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int WorldY
	{
		[Token(Token = "0x600707A")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600707B")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x6007075")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapCoordinates()
	{
	}

	[Token(Token = "0x6007076")]
	[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapCoordinates(MapCoordinates other)
	{
	}

	[Token(Token = "0x6007077")]
	[Address(RVA = "0xBE2960", Offset = "0xBE1D60", VA = "0x180BE2960", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MapCoordinates Clone()
	{
		return null;
	}

	[Token(Token = "0x600707C")]
	[Address(RVA = "0xBE29F0", Offset = "0xBE1DF0", VA = "0x180BE29F0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600707D")]
	[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(MapCoordinates other)
	{
		return default(bool);
	}

	[Token(Token = "0x600707E")]
	[Address(RVA = "0x9691C0", Offset = "0x9685C0", VA = "0x1809691C0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600707F")]
	[Address(RVA = "0xBE2A80", Offset = "0xBE1E80", VA = "0x180BE2A80", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007080")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007081")]
	[Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007082")]
	[Address(RVA = "0xBE28A0", Offset = "0xBE1CA0", VA = "0x180BE28A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007083")]
	[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MapCoordinates other)
	{
	}

	[Token(Token = "0x6007084")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007085")]
	[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
