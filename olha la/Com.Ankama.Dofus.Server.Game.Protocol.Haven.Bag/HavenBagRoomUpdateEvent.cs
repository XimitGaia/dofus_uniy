using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Haven.Bag;

[Token(Token = "0x2000433")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class HavenBagRoomUpdateEvent : IMessage<HavenBagRoomUpdateEvent>, IMessage, IEquatable<HavenBagRoomUpdateEvent>, IDeepCloneable<HavenBagRoomUpdateEvent>, IBufferMessage
{
	[Token(Token = "0x2000434")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x2000435")]
		public enum HavenBagRoomAction
		{
			[Token(Token = "0x4000E95")]
			[OriginalName("HAVEN_BAG_ROOM_DISPATCH")]
			HavenBagRoomDispatch,
			[Token(Token = "0x4000E96")]
			[OriginalName("HAVEN_BAG_ROOM_UPDATE")]
			HavenBagRoomUpdate
		}

		[Token(Token = "0x2000436")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class HavenBagRoomPreview : IMessage<HavenBagRoomPreview>, IMessage, IEquatable<HavenBagRoomPreview>, IDeepCloneable<HavenBagRoomPreview>, IBufferMessage
		{
			[Token(Token = "0x4000E97")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<HavenBagRoomPreview> _parser;

			[Token(Token = "0x4000E98")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x4000E99")]
			public const int RoomIdFieldNumber = 1;

			[Token(Token = "0x4000E9A")]
			[FieldOffset(Offset = "0x18")]
			private int roomId_;

			[Token(Token = "0x4000E9B")]
			public const int ThemeIdFieldNumber = 2;

			[Token(Token = "0x4000E9C")]
			[FieldOffset(Offset = "0x1C")]
			private int themeId_;

			[Token(Token = "0x17000982")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<HavenBagRoomPreview> Parser
			{
				[Token(Token = "0x6002C6C")]
				[Address(RVA = "0x9C2F20", Offset = "0x9C2320", VA = "0x1809C2F20")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000983")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6002C6D")]
				[Address(RVA = "0x9C2EA0", Offset = "0x9C22A0", VA = "0x1809C2EA0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000984")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6002C6E")]
				[Address(RVA = "0x9C2F70", Offset = "0x9C2370", VA = "0x1809C2F70", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000985")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int RoomId
			{
				[Token(Token = "0x6002C72")]
				[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6002C73")]
				[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
				set
				{
				}
			}

			[Token(Token = "0x17000986")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int ThemeId
			{
				[Token(Token = "0x6002C74")]
				[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6002C75")]
				[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
				set
				{
				}
			}

			[Token(Token = "0x6002C6F")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public HavenBagRoomPreview()
			{
			}

			[Token(Token = "0x6002C70")]
			[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public HavenBagRoomPreview(HavenBagRoomPreview other)
			{
			}

			[Token(Token = "0x6002C71")]
			[Address(RVA = "0x9C2C20", Offset = "0x9C2020", VA = "0x1809C2C20", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public HavenBagRoomPreview Clone()
			{
				return null;
			}

			[Token(Token = "0x6002C76")]
			[Address(RVA = "0x9C2CB0", Offset = "0x9C20B0", VA = "0x1809C2CB0", Slot = "0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6002C77")]
			[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool Equals(HavenBagRoomPreview other)
			{
				return default(bool);
			}

			[Token(Token = "0x6002C78")]
			[Address(RVA = "0x9691C0", Offset = "0x9685C0", VA = "0x1809691C0", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6002C79")]
			[Address(RVA = "0x9C2D40", Offset = "0x9C2140", VA = "0x1809C2D40", Slot = "3")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6002C7A")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6002C7B")]
			[Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6002C7C")]
			[Address(RVA = "0x9C2B60", Offset = "0x9C1F60", VA = "0x1809C2B60", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6002C7D")]
			[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(HavenBagRoomPreview other)
			{
			}

			[Token(Token = "0x6002C7E")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6002C7F")]
			[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x4000E8D")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<HavenBagRoomUpdateEvent> _parser;

	[Token(Token = "0x4000E8E")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000E8F")]
	public const int ActionFieldNumber = 1;

	[Token(Token = "0x4000E90")]
	[FieldOffset(Offset = "0x18")]
	private Types.HavenBagRoomAction action_;

	[Token(Token = "0x4000E91")]
	public const int PreviewFieldNumber = 2;

	[Token(Token = "0x4000E92")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<Types.HavenBagRoomPreview> _repeated_preview_codec;

	[Token(Token = "0x4000E93")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<Types.HavenBagRoomPreview> preview_;

	[Token(Token = "0x1700097D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HavenBagRoomUpdateEvent> Parser
	{
		[Token(Token = "0x6002C58")]
		[Address(RVA = "0x9C3790", Offset = "0x9C2B90", VA = "0x1809C3790")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700097E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002C59")]
		[Address(RVA = "0x9C36E0", Offset = "0x9C2AE0", VA = "0x1809C36E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700097F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002C5A")]
		[Address(RVA = "0x9C39E0", Offset = "0x9C2DE0", VA = "0x1809C39E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000980")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.HavenBagRoomAction Action
	{
		[Token(Token = "0x6002C5E")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(Types.HavenBagRoomAction);
		}
		[Token(Token = "0x6002C5F")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000981")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<Types.HavenBagRoomPreview> Preview
	{
		[Token(Token = "0x6002C60")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002C5B")]
	[Address(RVA = "0x9C3660", Offset = "0x9C2A60", VA = "0x1809C3660")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public HavenBagRoomUpdateEvent()
	{
	}

	[Token(Token = "0x6002C5C")]
	[Address(RVA = "0x9C35D0", Offset = "0x9C29D0", VA = "0x1809C35D0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public HavenBagRoomUpdateEvent(HavenBagRoomUpdateEvent other)
	{
	}

	[Token(Token = "0x6002C5D")]
	[Address(RVA = "0x9C3100", Offset = "0x9C2500", VA = "0x1809C3100", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public HavenBagRoomUpdateEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6002C61")]
	[Address(RVA = "0x9C31C0", Offset = "0x9C25C0", VA = "0x1809C31C0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002C62")]
	[Address(RVA = "0x9C32A0", Offset = "0x9C26A0", VA = "0x1809C32A0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(HavenBagRoomUpdateEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002C63")]
	[Address(RVA = "0x971040", Offset = "0x970440", VA = "0x180971040", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002C64")]
	[Address(RVA = "0x9C33D0", Offset = "0x9C27D0", VA = "0x1809C33D0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002C65")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002C66")]
	[Address(RVA = "0x9C3910", Offset = "0x9C2D10", VA = "0x1809C3910", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002C67")]
	[Address(RVA = "0x9C3020", Offset = "0x9C2420", VA = "0x1809C3020", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002C68")]
	[Address(RVA = "0x9C3340", Offset = "0x9C2740", VA = "0x1809C3340", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HavenBagRoomUpdateEvent other)
	{
	}

	[Token(Token = "0x6002C69")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002C6A")]
	[Address(RVA = "0x9C37E0", Offset = "0x9C2BE0", VA = "0x1809C37E0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
