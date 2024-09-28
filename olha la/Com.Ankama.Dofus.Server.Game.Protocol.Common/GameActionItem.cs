using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000AEE")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GameActionItem : IMessage<GameActionItem>, IMessage, IEquatable<GameActionItem>, IDeepCloneable<GameActionItem>, IBufferMessage
{
	[Token(Token = "0x4002840")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GameActionItem> _parser;

	[Token(Token = "0x4002841")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002842")]
	public const int IdFieldNumber = 1;

	[Token(Token = "0x4002843")]
	[FieldOffset(Offset = "0x18")]
	private int id_;

	[Token(Token = "0x4002844")]
	public const int TitleFieldNumber = 2;

	[Token(Token = "0x4002845")]
	[FieldOffset(Offset = "0x20")]
	private string title_;

	[Token(Token = "0x4002846")]
	public const int TextFieldNumber = 3;

	[Token(Token = "0x4002847")]
	[FieldOffset(Offset = "0x28")]
	private string text_;

	[Token(Token = "0x4002848")]
	public const int DescUrlFieldNumber = 4;

	[Token(Token = "0x4002849")]
	[FieldOffset(Offset = "0x30")]
	private string descUrl_;

	[Token(Token = "0x400284A")]
	public const int PictureUrlFieldNumber = 5;

	[Token(Token = "0x400284B")]
	[FieldOffset(Offset = "0x38")]
	private string pictureUrl_;

	[Token(Token = "0x400284C")]
	public const int ItemsFieldNumber = 6;

	[Token(Token = "0x400284D")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<ItemMinimalInformation> _repeated_items_codec;

	[Token(Token = "0x400284E")]
	[FieldOffset(Offset = "0x40")]
	private readonly RepeatedField<ItemMinimalInformation> items_;

	[Token(Token = "0x1700191C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GameActionItem> Parser
	{
		[Token(Token = "0x60072C1")]
		[Address(RVA = "0xBF18F0", Offset = "0xBF0CF0", VA = "0x180BF18F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700191D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60072C2")]
		[Address(RVA = "0xBF1840", Offset = "0xBF0C40", VA = "0x180BF1840")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700191E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60072C3")]
		[Address(RVA = "0xBF1CF0", Offset = "0xBF10F0", VA = "0x180BF1CF0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700191F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Id
	{
		[Token(Token = "0x60072C7")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60072C8")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17001920")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string Title
	{
		[Token(Token = "0x60072C9")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x60072CA")]
		[Address(RVA = "0xBF1F20", Offset = "0xBF1320", VA = "0x180BF1F20")]
		set
		{
		}
	}

	[Token(Token = "0x17001921")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string Text
	{
		[Token(Token = "0x60072CB")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60072CC")]
		[Address(RVA = "0xBF1EB0", Offset = "0xBF12B0", VA = "0x180BF1EB0")]
		set
		{
		}
	}

	[Token(Token = "0x17001922")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string DescUrl
	{
		[Token(Token = "0x60072CD")]
		[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60072CE")]
		[Address(RVA = "0xBF1DD0", Offset = "0xBF11D0", VA = "0x180BF1DD0")]
		set
		{
		}
	}

	[Token(Token = "0x17001923")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string PictureUrl
	{
		[Token(Token = "0x60072CF")]
		[Address(RVA = "0x87D8A0", Offset = "0x87CCA0", VA = "0x18087D8A0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60072D0")]
		[Address(RVA = "0xBF1E40", Offset = "0xBF1240", VA = "0x180BF1E40")]
		set
		{
		}
	}

	[Token(Token = "0x17001924")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ItemMinimalInformation> Items
	{
		[Token(Token = "0x60072D1")]
		[Address(RVA = "0x7D6D10", Offset = "0x7D6110", VA = "0x1807D6D10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60072C4")]
	[Address(RVA = "0xBF1670", Offset = "0xBF0A70", VA = "0x180BF1670")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GameActionItem()
	{
	}

	[Token(Token = "0x60072C5")]
	[Address(RVA = "0xBF1760", Offset = "0xBF0B60", VA = "0x180BF1760")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GameActionItem(GameActionItem other)
	{
	}

	[Token(Token = "0x60072C6")]
	[Address(RVA = "0xBF0F00", Offset = "0xBF0300", VA = "0x180BF0F00", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GameActionItem Clone()
	{
		return null;
	}

	[Token(Token = "0x60072D2")]
	[Address(RVA = "0xBF1100", Offset = "0xBF0500", VA = "0x180BF1100", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60072D3")]
	[Address(RVA = "0xBF1000", Offset = "0xBF0400", VA = "0x180BF1000", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GameActionItem other)
	{
		return default(bool);
	}

	[Token(Token = "0x60072D4")]
	[Address(RVA = "0xBF1240", Offset = "0xBF0640", VA = "0x180BF1240", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60072D5")]
	[Address(RVA = "0xBF1470", Offset = "0xBF0870", VA = "0x180BF1470", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60072D6")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60072D7")]
	[Address(RVA = "0xBF1B60", Offset = "0xBF0F60", VA = "0x180BF1B60", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60072D8")]
	[Address(RVA = "0xBF0D40", Offset = "0xBF0140", VA = "0x180BF0D40", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60072D9")]
	[Address(RVA = "0xBF1370", Offset = "0xBF0770", VA = "0x180BF1370", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GameActionItem other)
	{
	}

	[Token(Token = "0x60072DA")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60072DB")]
	[Address(RVA = "0xBF1940", Offset = "0xBF0D40", VA = "0x180BF1940", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
