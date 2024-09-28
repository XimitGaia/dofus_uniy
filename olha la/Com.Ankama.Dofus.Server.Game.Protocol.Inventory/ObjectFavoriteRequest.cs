using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory;

[Token(Token = "0x2000396")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ObjectFavoriteRequest : IMessage<ObjectFavoriteRequest>, IMessage, IEquatable<ObjectFavoriteRequest>, IDeepCloneable<ObjectFavoriteRequest>, IBufferMessage
{
	[Token(Token = "0x2000397")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x2000398")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class ObjectFavorite : IMessage<ObjectFavorite>, IMessage, IEquatable<ObjectFavorite>, IDeepCloneable<ObjectFavorite>, IBufferMessage
		{
			[Token(Token = "0x4000C68")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<ObjectFavorite> _parser;

			[Token(Token = "0x4000C69")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x4000C6A")]
			public const int ObjectUidFieldNumber = 1;

			[Token(Token = "0x4000C6B")]
			[FieldOffset(Offset = "0x18")]
			private int objectUid_;

			[Token(Token = "0x4000C6C")]
			public const int PositionFieldNumber = 2;

			[Token(Token = "0x4000C6D")]
			[FieldOffset(Offset = "0x1C")]
			private int position_;

			[Token(Token = "0x17000804")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageParser<ObjectFavorite> Parser
			{
				[Token(Token = "0x600255F")]
				[Address(RVA = "0x98F490", Offset = "0x98E890", VA = "0x18098F490")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000805")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6002560")]
				[Address(RVA = "0x98F410", Offset = "0x98E810", VA = "0x18098F410")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000806")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6002561")]
				[Address(RVA = "0x98F4E0", Offset = "0x98E8E0", VA = "0x18098F4E0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000807")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int ObjectUid
			{
				[Token(Token = "0x6002565")]
				[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6002566")]
				[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
				set
				{
				}
			}

			[Token(Token = "0x17000808")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int Position
			{
				[Token(Token = "0x6002567")]
				[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6002568")]
				[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
				set
				{
				}
			}

			[Token(Token = "0x6002562")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public ObjectFavorite()
			{
			}

			[Token(Token = "0x6002563")]
			[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public ObjectFavorite(ObjectFavorite other)
			{
			}

			[Token(Token = "0x6002564")]
			[Address(RVA = "0x98F190", Offset = "0x98E590", VA = "0x18098F190", Slot = "10")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public ObjectFavorite Clone()
			{
				return null;
			}

			[Token(Token = "0x6002569")]
			[Address(RVA = "0x98F220", Offset = "0x98E620", VA = "0x18098F220", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x600256A")]
			[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(ObjectFavorite other)
			{
				return default(bool);
			}

			[Token(Token = "0x600256B")]
			[Address(RVA = "0x9691C0", Offset = "0x9685C0", VA = "0x1809691C0", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x600256C")]
			[Address(RVA = "0x98F2B0", Offset = "0x98E6B0", VA = "0x18098F2B0", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x600256D")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x600256E")]
			[Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x600256F")]
			[Address(RVA = "0x98F0D0", Offset = "0x98E4D0", VA = "0x18098F0D0", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6002570")]
			[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(ObjectFavorite other)
			{
			}

			[Token(Token = "0x6002571")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6002572")]
			[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x4000C61")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ObjectFavoriteRequest> _parser;

	[Token(Token = "0x4000C62")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000C63")]
	public const int ObjectsFieldNumber = 1;

	[Token(Token = "0x4000C64")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<Types.ObjectFavorite> _repeated_objects_codec;

	[Token(Token = "0x4000C65")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<Types.ObjectFavorite> objects_;

	[Token(Token = "0x4000C66")]
	public const int FavoriteFieldNumber = 2;

	[Token(Token = "0x4000C67")]
	[FieldOffset(Offset = "0x20")]
	private bool favorite_;

	[Token(Token = "0x170007FF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ObjectFavoriteRequest> Parser
	{
		[Token(Token = "0x600254B")]
		[Address(RVA = "0x98E950", Offset = "0x98DD50", VA = "0x18098E950")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000800")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600254C")]
		[Address(RVA = "0x98E8A0", Offset = "0x98DCA0", VA = "0x18098E8A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000801")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600254D")]
		[Address(RVA = "0x98EBA0", Offset = "0x98DFA0", VA = "0x18098EBA0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000802")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<Types.ObjectFavorite> Objects
	{
		[Token(Token = "0x6002551")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000803")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Favorite
	{
		[Token(Token = "0x6002552")]
		[Address(RVA = "0x7F9A60", Offset = "0x7F8E60", VA = "0x1807F9A60")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002553")]
		[Address(RVA = "0x7F9A70", Offset = "0x7F8E70", VA = "0x1807F9A70")]
		set
		{
		}
	}

	[Token(Token = "0x600254E")]
	[Address(RVA = "0x98E820", Offset = "0x98DC20", VA = "0x18098E820")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ObjectFavoriteRequest()
	{
	}

	[Token(Token = "0x600254F")]
	[Address(RVA = "0x98E790", Offset = "0x98DB90", VA = "0x18098E790")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectFavoriteRequest(ObjectFavoriteRequest other)
	{
	}

	[Token(Token = "0x6002550")]
	[Address(RVA = "0x98E200", Offset = "0x98D600", VA = "0x18098E200", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectFavoriteRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6002554")]
	[Address(RVA = "0x98E360", Offset = "0x98D760", VA = "0x18098E360", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002555")]
	[Address(RVA = "0x98E2C0", Offset = "0x98D6C0", VA = "0x18098E2C0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ObjectFavoriteRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002556")]
	[Address(RVA = "0x98E440", Offset = "0x98D840", VA = "0x18098E440", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002557")]
	[Address(RVA = "0x98E590", Offset = "0x98D990", VA = "0x18098E590", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002558")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002559")]
	[Address(RVA = "0x98EAD0", Offset = "0x98DED0", VA = "0x18098EAD0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600255A")]
	[Address(RVA = "0x98E150", Offset = "0x98D550", VA = "0x18098E150", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600255B")]
	[Address(RVA = "0x98E500", Offset = "0x98D900", VA = "0x18098E500", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ObjectFavoriteRequest other)
	{
	}

	[Token(Token = "0x600255C")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600255D")]
	[Address(RVA = "0x98E9A0", Offset = "0x98DDA0", VA = "0x18098E9A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
