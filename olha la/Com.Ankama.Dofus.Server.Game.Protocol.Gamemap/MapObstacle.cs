using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Gamemap;

[Token(Token = "0x2000552")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MapObstacle : IMessage<MapObstacle>, IMessage, IEquatable<MapObstacle>, IDeepCloneable<MapObstacle>, IBufferMessage
{
	[Token(Token = "0x2000553")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x2000554")]
		public enum ObstacleState
		{
			[Token(Token = "0x4001249")]
			[OriginalName("OBSTACLE_OPENED")]
			ObstacleOpened,
			[Token(Token = "0x400124A")]
			[OriginalName("OBSTACLE_CLOSED")]
			ObstacleClosed
		}
	}

	[Token(Token = "0x4001242")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<MapObstacle> _parser;

	[Token(Token = "0x4001243")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001244")]
	public const int CellIdFieldNumber = 1;

	[Token(Token = "0x4001245")]
	[FieldOffset(Offset = "0x18")]
	private int cellId_;

	[Token(Token = "0x4001246")]
	public const int StateFieldNumber = 2;

	[Token(Token = "0x4001247")]
	[FieldOffset(Offset = "0x1C")]
	private Types.ObstacleState state_;

	[Token(Token = "0x17000C05")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<MapObstacle> Parser
	{
		[Token(Token = "0x600388B")]
		[Address(RVA = "0xA25C70", Offset = "0xA25070", VA = "0x180A25C70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C06")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600388C")]
		[Address(RVA = "0xA25BC0", Offset = "0xA24FC0", VA = "0x180A25BC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C07")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600388D")]
		[Address(RVA = "0xA25D40", Offset = "0xA25140", VA = "0x180A25D40", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C08")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CellId
	{
		[Token(Token = "0x6003891")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6003892")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000C09")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.ObstacleState State
	{
		[Token(Token = "0x6003893")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(Types.ObstacleState);
		}
		[Token(Token = "0x6003894")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x600388E")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapObstacle()
	{
	}

	[Token(Token = "0x600388F")]
	[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapObstacle(MapObstacle other)
	{
	}

	[Token(Token = "0x6003890")]
	[Address(RVA = "0xA25940", Offset = "0xA24D40", VA = "0x180A25940", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapObstacle Clone()
	{
		return null;
	}

	[Token(Token = "0x6003895")]
	[Address(RVA = "0xA259D0", Offset = "0xA24DD0", VA = "0x180A259D0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003896")]
	[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(MapObstacle other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003897")]
	[Address(RVA = "0x93AAA0", Offset = "0x939EA0", VA = "0x18093AAA0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6003898")]
	[Address(RVA = "0xA25A60", Offset = "0xA24E60", VA = "0x180A25A60", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6003899")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600389A")]
	[Address(RVA = "0xA25CC0", Offset = "0xA250C0", VA = "0x180A25CC0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600389B")]
	[Address(RVA = "0xA25880", Offset = "0xA24C80", VA = "0x180A25880", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600389C")]
	[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MapObstacle other)
	{
	}

	[Token(Token = "0x600389D")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600389E")]
	[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
