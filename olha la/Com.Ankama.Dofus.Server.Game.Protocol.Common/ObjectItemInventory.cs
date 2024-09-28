using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000AD4")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ObjectItemInventory : IMessage<ObjectItemInventory>, IMessage, IEquatable<ObjectItemInventory>, IDeepCloneable<ObjectItemInventory>, IBufferMessage
{
	[Token(Token = "0x40027A9")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ObjectItemInventory> _parser;

	[Token(Token = "0x40027AA")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40027AB")]
	public const int PositionFieldNumber = 1;

	[Token(Token = "0x40027AC")]
	[FieldOffset(Offset = "0x18")]
	private int position_;

	[Token(Token = "0x40027AD")]
	public const int ItemFieldNumber = 2;

	[Token(Token = "0x40027AE")]
	[FieldOffset(Offset = "0x20")]
	private ObjectItem item_;

	[Token(Token = "0x40027AF")]
	public const int FavoriteFieldNumber = 3;

	[Token(Token = "0x40027B0")]
	[FieldOffset(Offset = "0x28")]
	private bool favorite_;

	[Token(Token = "0x40027B1")]
	public const int TagStorageUuidsFieldNumber = 4;

	[Token(Token = "0x40027B2")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<string> _repeated_tagStorageUuids_codec;

	[Token(Token = "0x40027B3")]
	[FieldOffset(Offset = "0x30")]
	private readonly RepeatedField<string> tagStorageUuids_;

	[Token(Token = "0x170018C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ObjectItemInventory> Parser
	{
		[Token(Token = "0x6007173")]
		[Address(RVA = "0xBF9480", Offset = "0xBF8880", VA = "0x180BF9480")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170018C1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007174")]
		[Address(RVA = "0xBF93D0", Offset = "0xBF87D0", VA = "0x180BF93D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170018C2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007175")]
		[Address(RVA = "0xBF97A0", Offset = "0xBF8BA0", VA = "0x180BF97A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170018C3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Position
	{
		[Token(Token = "0x6007179")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600717A")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170018C4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ObjectItem Item
	{
		[Token(Token = "0x600717B")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x600717C")]
		[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
		set
		{
		}
	}

	[Token(Token = "0x170018C5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Favorite
	{
		[Token(Token = "0x600717D")]
		[Address(RVA = "0x8529D0", Offset = "0x851DD0", VA = "0x1808529D0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600717E")]
		[Address(RVA = "0x9A1E80", Offset = "0x9A1280", VA = "0x1809A1E80")]
		set
		{
		}
	}

	[Token(Token = "0x170018C6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<string> TagStorageUuids
	{
		[Token(Token = "0x600717F")]
		[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007176")]
	[Address(RVA = "0xBF91D0", Offset = "0xBF85D0", VA = "0x180BF91D0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectItemInventory()
	{
	}

	[Token(Token = "0x6007177")]
	[Address(RVA = "0xBF9250", Offset = "0xBF8650", VA = "0x180BF9250")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectItemInventory(ObjectItemInventory other)
	{
	}

	[Token(Token = "0x6007178")]
	[Address(RVA = "0xBF8A50", Offset = "0xBF7E50", VA = "0x180BF8A50", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectItemInventory Clone()
	{
		return null;
	}

	[Token(Token = "0x6007180")]
	[Address(RVA = "0xBF8CC0", Offset = "0xBF80C0", VA = "0x180BF8CC0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007181")]
	[Address(RVA = "0xBF8C00", Offset = "0xBF8000", VA = "0x180BF8C00", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(ObjectItemInventory other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007182")]
	[Address(RVA = "0xBF8DC0", Offset = "0xBF81C0", VA = "0x180BF8DC0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007183")]
	[Address(RVA = "0xBF9040", Offset = "0xBF8440", VA = "0x180BF9040", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007184")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007185")]
	[Address(RVA = "0xBF9680", Offset = "0xBF8A80", VA = "0x180BF9680", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007186")]
	[Address(RVA = "0xBF8930", Offset = "0xBF7D30", VA = "0x180BF8930", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007187")]
	[Address(RVA = "0xBF8EC0", Offset = "0xBF82C0", VA = "0x180BF8EC0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ObjectItemInventory other)
	{
	}

	[Token(Token = "0x6007188")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007189")]
	[Address(RVA = "0xBF94D0", Offset = "0xBF88D0", VA = "0x180BF94D0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
