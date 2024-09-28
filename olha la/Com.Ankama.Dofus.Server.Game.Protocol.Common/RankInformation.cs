using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000B06")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class RankInformation : IMessage<RankInformation>, IMessage, IEquatable<RankInformation>, IDeepCloneable<RankInformation>, IBufferMessage
{
	[Token(Token = "0x2000B07")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x2000B08")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class OrderAndGfx : IMessage<OrderAndGfx>, IMessage, IEquatable<OrderAndGfx>, IDeepCloneable<OrderAndGfx>, IBufferMessage
		{
			[Token(Token = "0x40028D4")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<OrderAndGfx> _parser;

			[Token(Token = "0x40028D5")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x40028D6")]
			public const int OrderFieldNumber = 1;

			[Token(Token = "0x40028D7")]
			[FieldOffset(Offset = "0x18")]
			private int order_;

			[Token(Token = "0x40028D8")]
			public const int GfxIdFieldNumber = 2;

			[Token(Token = "0x40028D9")]
			[FieldOffset(Offset = "0x1C")]
			private int gfxId_;

			[Token(Token = "0x1700196D")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<OrderAndGfx> Parser
			{
				[Token(Token = "0x60073E9")]
				[Address(RVA = "0xC069C0", Offset = "0xC05DC0", VA = "0x180C069C0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700196E")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x60073EA")]
				[Address(RVA = "0xC06940", Offset = "0xC05D40", VA = "0x180C06940")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700196F")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x60073EB")]
				[Address(RVA = "0xC06A10", Offset = "0xC05E10", VA = "0x180C06A10", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001970")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int Order
			{
				[Token(Token = "0x60073EF")]
				[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x60073F0")]
				[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
				set
				{
				}
			}

			[Token(Token = "0x17001971")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int GfxId
			{
				[Token(Token = "0x60073F1")]
				[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x60073F2")]
				[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
				set
				{
				}
			}

			[Token(Token = "0x60073EC")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public OrderAndGfx()
			{
			}

			[Token(Token = "0x60073ED")]
			[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public OrderAndGfx(OrderAndGfx other)
			{
			}

			[Token(Token = "0x60073EE")]
			[Address(RVA = "0xC066C0", Offset = "0xC05AC0", VA = "0x180C066C0", Slot = "10")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public OrderAndGfx Clone()
			{
				return null;
			}

			[Token(Token = "0x60073F3")]
			[Address(RVA = "0xC06750", Offset = "0xC05B50", VA = "0x180C06750", Slot = "0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x60073F4")]
			[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(OrderAndGfx other)
			{
				return default(bool);
			}

			[Token(Token = "0x60073F5")]
			[Address(RVA = "0x9691C0", Offset = "0x9685C0", VA = "0x1809691C0", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x60073F6")]
			[Address(RVA = "0xC067E0", Offset = "0xC05BE0", VA = "0x180C067E0", Slot = "3")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x60073F7")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x60073F8")]
			[Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "12")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x60073F9")]
			[Address(RVA = "0xC06600", Offset = "0xC05A00", VA = "0x180C06600", Slot = "7")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x60073FA")]
			[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(OrderAndGfx other)
			{
			}

			[Token(Token = "0x60073FB")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x60073FC")]
			[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}

		[Token(Token = "0x2000B0A")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class PrivateInformation : IMessage<PrivateInformation>, IMessage, IEquatable<PrivateInformation>, IDeepCloneable<PrivateInformation>, IBufferMessage
		{
			[Token(Token = "0x40028DB")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<PrivateInformation> _parser;

			[Token(Token = "0x40028DC")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x40028DD")]
			public const int ModifiableFieldNumber = 1;

			[Token(Token = "0x40028DE")]
			[FieldOffset(Offset = "0x18")]
			private bool modifiable_;

			[Token(Token = "0x40028DF")]
			public const int RightsFieldNumber = 2;

			[Token(Token = "0x40028E0")]
			[FieldOffset(Offset = "0x8")]
			private static readonly FieldCodec<int> _repeated_rights_codec;

			[Token(Token = "0x40028E1")]
			[FieldOffset(Offset = "0x20")]
			private readonly RepeatedField<int> rights_;

			[Token(Token = "0x17001972")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<PrivateInformation> Parser
			{
				[Token(Token = "0x6007401")]
				[Address(RVA = "0xC0AC60", Offset = "0xC0A060", VA = "0x180C0AC60")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001973")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6007402")]
				[Address(RVA = "0xC0ABE0", Offset = "0xC09FE0", VA = "0x180C0ABE0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001974")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6007403")]
				[Address(RVA = "0xC0AEB0", Offset = "0xC0A2B0", VA = "0x180C0AEB0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001975")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool Modifiable
			{
				[Token(Token = "0x6007407")]
				[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6007408")]
				[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
				set
				{
				}
			}

			[Token(Token = "0x17001976")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public RepeatedField<int> Rights
			{
				[Token(Token = "0x6007409")]
				[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6007404")]
			[Address(RVA = "0xC0AB60", Offset = "0xC09F60", VA = "0x180C0AB60")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public PrivateInformation()
			{
			}

			[Token(Token = "0x6007405")]
			[Address(RVA = "0xC0AAD0", Offset = "0xC09ED0", VA = "0x180C0AAD0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public PrivateInformation(PrivateInformation other)
			{
			}

			[Token(Token = "0x6007406")]
			[Address(RVA = "0xC0A5B0", Offset = "0xC099B0", VA = "0x180C0A5B0", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public PrivateInformation Clone()
			{
				return null;
			}

			[Token(Token = "0x600740A")]
			[Address(RVA = "0xC0A670", Offset = "0xC09A70", VA = "0x180C0A670", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x600740B")]
			[Address(RVA = "0xC0A750", Offset = "0xC09B50", VA = "0x180C0A750", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(PrivateInformation other)
			{
				return default(bool);
			}

			[Token(Token = "0x600740C")]
			[Address(RVA = "0xC0A7F0", Offset = "0xC09BF0", VA = "0x180C0A7F0", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x600740D")]
			[Address(RVA = "0xC0A940", Offset = "0xC09D40", VA = "0x180C0A940", Slot = "3")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x600740E")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x600740F")]
			[Address(RVA = "0xC0ADE0", Offset = "0xC0A1E0", VA = "0x180C0ADE0", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6007410")]
			[Address(RVA = "0xC0A4F0", Offset = "0xC098F0", VA = "0x180C0A4F0", Slot = "7")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6007411")]
			[Address(RVA = "0xC0A8B0", Offset = "0xC09CB0", VA = "0x180C0A8B0", Slot = "4")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(PrivateInformation other)
			{
			}

			[Token(Token = "0x6007412")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6007413")]
			[Address(RVA = "0xC0ACB0", Offset = "0xC0A0B0", VA = "0x180C0ACB0", Slot = "11")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x40028CA")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<RankInformation> _parser;

	[Token(Token = "0x40028CB")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40028CC")]
	public const int IdFieldNumber = 1;

	[Token(Token = "0x40028CD")]
	[FieldOffset(Offset = "0x18")]
	private int id_;

	[Token(Token = "0x40028CE")]
	public const int NameFieldNumber = 2;

	[Token(Token = "0x40028CF")]
	[FieldOffset(Offset = "0x20")]
	private string name_;

	[Token(Token = "0x40028D0")]
	public const int OrderAndGfxFieldNumber = 3;

	[Token(Token = "0x40028D1")]
	[FieldOffset(Offset = "0x28")]
	private Types.OrderAndGfx orderAndGfx_;

	[Token(Token = "0x40028D2")]
	public const int PrivateInformationFieldNumber = 4;

	[Token(Token = "0x40028D3")]
	[FieldOffset(Offset = "0x30")]
	private Types.PrivateInformation privateInformation_;

	[Token(Token = "0x17001966")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RankInformation> Parser
	{
		[Token(Token = "0x60073D0")]
		[Address(RVA = "0xC0B960", Offset = "0xC0AD60", VA = "0x180C0B960")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001967")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60073D1")]
		[Address(RVA = "0xC0B8B0", Offset = "0xC0ACB0", VA = "0x180C0B8B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001968")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60073D2")]
		[Address(RVA = "0xC0BC30", Offset = "0xC0B030", VA = "0x180C0BC30", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001969")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Id
	{
		[Token(Token = "0x60073D6")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60073D7")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x1700196A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Name
	{
		[Token(Token = "0x60073D8")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x60073D9")]
		[Address(RVA = "0xC0BC70", Offset = "0xC0B070", VA = "0x180C0BC70")]
		set
		{
		}
	}

	[Token(Token = "0x1700196B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.OrderAndGfx OrderAndGfx
	{
		[Token(Token = "0x60073DA")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60073DB")]
		[Address(RVA = "0x96C220", Offset = "0x96B620", VA = "0x18096C220")]
		set
		{
		}
	}

	[Token(Token = "0x1700196C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.PrivateInformation PrivateInformation
	{
		[Token(Token = "0x60073DC")]
		[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60073DD")]
		[Address(RVA = "0xA34B30", Offset = "0xA33F30", VA = "0x180A34B30")]
		set
		{
		}
	}

	[Token(Token = "0x60073D3")]
	[Address(RVA = "0xC0B670", Offset = "0xC0AA70", VA = "0x180C0B670")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RankInformation()
	{
	}

	[Token(Token = "0x60073D4")]
	[Address(RVA = "0xC0B6C0", Offset = "0xC0AAC0", VA = "0x180C0B6C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RankInformation(RankInformation other)
	{
	}

	[Token(Token = "0x60073D5")]
	[Address(RVA = "0xC0B070", Offset = "0xC0A470", VA = "0x180C0B070", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RankInformation Clone()
	{
		return null;
	}

	[Token(Token = "0x60073DE")]
	[Address(RVA = "0xC0B0D0", Offset = "0xC0A4D0", VA = "0x180C0B0D0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60073DF")]
	[Address(RVA = "0xC0B1B0", Offset = "0xC0A5B0", VA = "0x180C0B1B0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RankInformation other)
	{
		return default(bool);
	}

	[Token(Token = "0x60073E0")]
	[Address(RVA = "0xC0B250", Offset = "0xC0A650", VA = "0x180C0B250", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60073E1")]
	[Address(RVA = "0xC0B510", Offset = "0xC0A910", VA = "0x180C0B510", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60073E2")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60073E3")]
	[Address(RVA = "0xC0BB60", Offset = "0xC0AF60", VA = "0x180C0BB60", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60073E4")]
	[Address(RVA = "0xC0AF60", Offset = "0xC0A360", VA = "0x180C0AF60", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60073E5")]
	[Address(RVA = "0xC0B320", Offset = "0xC0A720", VA = "0x180C0B320", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RankInformation other)
	{
	}

	[Token(Token = "0x60073E6")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60073E7")]
	[Address(RVA = "0xC0B9B0", Offset = "0xC0ADB0", VA = "0x180C0B9B0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
