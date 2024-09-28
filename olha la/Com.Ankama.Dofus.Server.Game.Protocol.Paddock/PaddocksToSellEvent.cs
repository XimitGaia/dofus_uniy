using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Paddock;

[Token(Token = "0x20002C5")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PaddocksToSellEvent : IMessage<PaddocksToSellEvent>, IMessage, IEquatable<PaddocksToSellEvent>, IDeepCloneable<PaddocksToSellEvent>, IBufferMessage
{
	[Token(Token = "0x20002C6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x20002C7")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class PaddockForSale : IMessage<PaddockForSale>, IMessage, IEquatable<PaddockForSale>, IDeepCloneable<PaddockForSale>, IBufferMessage
		{
			[Token(Token = "0x40009C2")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<PaddockForSale> _parser;

			[Token(Token = "0x40009C3")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x40009C4")]
			public const int GuildOwnerFieldNumber = 1;

			[Token(Token = "0x40009C5")]
			[FieldOffset(Offset = "0x18")]
			private string guildOwner_;

			[Token(Token = "0x40009C6")]
			public const int CoordinatesFieldNumber = 2;

			[Token(Token = "0x40009C7")]
			[FieldOffset(Offset = "0x20")]
			private MapCoordinates coordinates_;

			[Token(Token = "0x40009C8")]
			public const int SubAreaIdFieldNumber = 3;

			[Token(Token = "0x40009C9")]
			[FieldOffset(Offset = "0x28")]
			private int subAreaId_;

			[Token(Token = "0x40009CA")]
			public const int MountNumberFieldNumber = 4;

			[Token(Token = "0x40009CB")]
			[FieldOffset(Offset = "0x2C")]
			private int mountNumber_;

			[Token(Token = "0x40009CC")]
			public const int ObjectNumberFieldNumber = 5;

			[Token(Token = "0x40009CD")]
			[FieldOffset(Offset = "0x30")]
			private int objectNumber_;

			[Token(Token = "0x40009CE")]
			public const int PriceFieldNumber = 6;

			[Token(Token = "0x40009CF")]
			[FieldOffset(Offset = "0x38")]
			private long price_;

			[Token(Token = "0x1700063B")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<PaddockForSale> Parser
			{
				[Token(Token = "0x6001CE9")]
				[Address(RVA = "0xD073D0", Offset = "0xD067D0", VA = "0x180D073D0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700063C")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6001CEA")]
				[Address(RVA = "0xD07350", Offset = "0xD06750", VA = "0x180D07350")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700063D")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6001CEB")]
				[Address(RVA = "0xD076E0", Offset = "0xD06AE0", VA = "0x180D076E0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700063E")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public string GuildOwner
			{
				[Token(Token = "0x6001CEF")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return null;
				}
				[Token(Token = "0x6001CF0")]
				[Address(RVA = "0xD07790", Offset = "0xD06B90", VA = "0x180D07790")]
				set
				{
				}
			}

			[Token(Token = "0x1700063F")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public MapCoordinates Coordinates
			{
				[Token(Token = "0x6001CF1")]
				[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
				get
				{
					return null;
				}
				[Token(Token = "0x6001CF2")]
				[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
				set
				{
				}
			}

			[Token(Token = "0x17000640")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int SubAreaId
			{
				[Token(Token = "0x6001CF3")]
				[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6001CF4")]
				[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
				set
				{
				}
			}

			[Token(Token = "0x17000641")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int MountNumber
			{
				[Token(Token = "0x6001CF5")]
				[Address(RVA = "0x95FBF0", Offset = "0x95EFF0", VA = "0x18095FBF0")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6001CF6")]
				[Address(RVA = "0x960010", Offset = "0x95F410", VA = "0x180960010")]
				set
				{
				}
			}

			[Token(Token = "0x17000642")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int ObjectNumber
			{
				[Token(Token = "0x6001CF7")]
				[Address(RVA = "0x875C10", Offset = "0x875010", VA = "0x180875C10")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6001CF8")]
				[Address(RVA = "0x947120", Offset = "0x946520", VA = "0x180947120")]
				set
				{
				}
			}

			[Token(Token = "0x17000643")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public long Price
			{
				[Token(Token = "0x6001CF9")]
				[Address(RVA = "0x87D8A0", Offset = "0x87CCA0", VA = "0x18087D8A0")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x6001CFA")]
				[Address(RVA = "0x9EFE00", Offset = "0x9EF200", VA = "0x1809EFE00")]
				set
				{
				}
			}

			[Token(Token = "0x6001CEC")]
			[Address(RVA = "0xD07220", Offset = "0xD06620", VA = "0x180D07220")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public PaddockForSale()
			{
			}

			[Token(Token = "0x6001CED")]
			[Address(RVA = "0xD07270", Offset = "0xD06670", VA = "0x180D07270")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public PaddockForSale(PaddockForSale other)
			{
			}

			[Token(Token = "0x6001CEE")]
			[Address(RVA = "0xD06C10", Offset = "0xD06010", VA = "0x180D06C10", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public PaddockForSale Clone()
			{
				return null;
			}

			[Token(Token = "0x6001CFB")]
			[Address(RVA = "0xD06DC0", Offset = "0xD061C0", VA = "0x180D06DC0", Slot = "0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6001CFC")]
			[Address(RVA = "0xD06D20", Offset = "0xD06120", VA = "0x180D06D20", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(PaddockForSale other)
			{
				return default(bool);
			}

			[Token(Token = "0x6001CFD")]
			[Address(RVA = "0xD06EB0", Offset = "0xD062B0", VA = "0x180D06EB0", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6001CFE")]
			[Address(RVA = "0xD070C0", Offset = "0xD064C0", VA = "0x180D070C0", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6001CFF")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6001D00")]
			[Address(RVA = "0xD075D0", Offset = "0xD069D0", VA = "0x180D075D0", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6001D01")]
			[Address(RVA = "0xD06AB0", Offset = "0xD05EB0", VA = "0x180D06AB0", Slot = "7")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6001D02")]
			[Address(RVA = "0xD06FB0", Offset = "0xD063B0", VA = "0x180D06FB0", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(PaddockForSale other)
			{
			}

			[Token(Token = "0x6001D03")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6001D04")]
			[Address(RVA = "0xD07420", Offset = "0xD06820", VA = "0x180D07420", Slot = "11")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x40009B9")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PaddocksToSellEvent> _parser;

	[Token(Token = "0x40009BA")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40009BB")]
	public const int PageIndexFieldNumber = 1;

	[Token(Token = "0x40009BC")]
	[FieldOffset(Offset = "0x18")]
	private int pageIndex_;

	[Token(Token = "0x40009BD")]
	public const int PageTotalFieldNumber = 2;

	[Token(Token = "0x40009BE")]
	[FieldOffset(Offset = "0x1C")]
	private int pageTotal_;

	[Token(Token = "0x40009BF")]
	public const int PaddocksFieldNumber = 3;

	[Token(Token = "0x40009C0")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<Types.PaddockForSale> _repeated_paddocks_codec;

	[Token(Token = "0x40009C1")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<Types.PaddockForSale> paddocks_;

	[Token(Token = "0x17000635")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PaddocksToSellEvent> Parser
	{
		[Token(Token = "0x6001CD3")]
		[Address(RVA = "0xD0D990", Offset = "0xD0CD90", VA = "0x180D0D990")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000636")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001CD4")]
		[Address(RVA = "0xD0D8E0", Offset = "0xD0CCE0", VA = "0x180D0D8E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000637")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001CD5")]
		[Address(RVA = "0xD0DC20", Offset = "0xD0D020", VA = "0x180D0DC20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000638")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PageIndex
	{
		[Token(Token = "0x6001CD9")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001CDA")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000639")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PageTotal
	{
		[Token(Token = "0x6001CDB")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001CDC")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x1700063A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<Types.PaddockForSale> Paddocks
	{
		[Token(Token = "0x6001CDD")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001CD6")]
	[Address(RVA = "0xD0D860", Offset = "0xD0CC60", VA = "0x180D0D860")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PaddocksToSellEvent()
	{
	}

	[Token(Token = "0x6001CD7")]
	[Address(RVA = "0xD0D750", Offset = "0xD0CB50", VA = "0x180D0D750")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PaddocksToSellEvent(PaddocksToSellEvent other)
	{
	}

	[Token(Token = "0x6001CD8")]
	[Address(RVA = "0xD0D200", Offset = "0xD0C600", VA = "0x180D0D200", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PaddocksToSellEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6001CDE")]
	[Address(RVA = "0xD0D3D0", Offset = "0xD0C7D0", VA = "0x180D0D3D0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001CDF")]
	[Address(RVA = "0xD0D330", Offset = "0xD0C730", VA = "0x180D0D330", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PaddocksToSellEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001CE0")]
	[Address(RVA = "0x9C6C20", Offset = "0x9C6020", VA = "0x1809C6C20", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001CE1")]
	[Address(RVA = "0xD0D550", Offset = "0xD0C950", VA = "0x180D0D550", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001CE2")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001CE3")]
	[Address(RVA = "0xD0DB30", Offset = "0xD0CF30", VA = "0x180D0DB30", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001CE4")]
	[Address(RVA = "0xD0D0F0", Offset = "0xD0C4F0", VA = "0x180D0D0F0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001CE5")]
	[Address(RVA = "0xD0D4C0", Offset = "0xD0C8C0", VA = "0x180D0D4C0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(PaddocksToSellEvent other)
	{
	}

	[Token(Token = "0x6001CE6")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001CE7")]
	[Address(RVA = "0xD0D9E0", Offset = "0xD0CDE0", VA = "0x180D0D9E0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
