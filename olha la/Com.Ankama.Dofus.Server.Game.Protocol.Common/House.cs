using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000AA0")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class House : IMessage<House>, IMessage, IEquatable<House>, IDeepCloneable<House>, IBufferMessage
{
	[Token(Token = "0x2000AA1")]
	public enum InformationOneofCase
	{
		[Token(Token = "0x40026DB")]
		None = 0,
		[Token(Token = "0x40026DC")]
		HouseAccount = 3,
		[Token(Token = "0x40026DD")]
		HouseOnMap = 4,
		[Token(Token = "0x40026DE")]
		HouseInside = 5,
		[Token(Token = "0x40026DF")]
		HouseGuild = 6
	}

	[Token(Token = "0x2000AA2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x2000AA3")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class HouseAccount : IMessage<HouseAccount>, IMessage, IEquatable<HouseAccount>, IDeepCloneable<HouseAccount>, IBufferMessage
		{
			[Token(Token = "0x40026E0")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<HouseAccount> _parser;

			[Token(Token = "0x40026E1")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x40026E2")]
			public const int HouseInformationFieldNumber = 1;

			[Token(Token = "0x40026E3")]
			[FieldOffset(Offset = "0x18")]
			private HouseInstance houseInformation_;

			[Token(Token = "0x40026E4")]
			public const int CoordinatesFieldNumber = 2;

			[Token(Token = "0x40026E5")]
			[FieldOffset(Offset = "0x20")]
			private MapExtendedCoordinates coordinates_;

			[Token(Token = "0x17001840")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageParser<HouseAccount> Parser
			{
				[Token(Token = "0x6006F44")]
				[Address(RVA = "0xBDB410", Offset = "0xBDA810", VA = "0x180BDB410")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001841")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6006F45")]
				[Address(RVA = "0xBDB390", Offset = "0xBDA790", VA = "0x180BDB390")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001842")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6006F46")]
				[Address(RVA = "0xBDB5B0", Offset = "0xBDA9B0", VA = "0x180BDB5B0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001843")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public HouseInstance HouseInformation
			{
				[Token(Token = "0x6006F4A")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return null;
				}
				[Token(Token = "0x6006F4B")]
				[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
				set
				{
				}
			}

			[Token(Token = "0x17001844")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public MapExtendedCoordinates Coordinates
			{
				[Token(Token = "0x6006F4C")]
				[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
				get
				{
					return null;
				}
				[Token(Token = "0x6006F4D")]
				[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
				set
				{
				}
			}

			[Token(Token = "0x6006F47")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public HouseAccount()
			{
			}

			[Token(Token = "0x6006F48")]
			[Address(RVA = "0xBDB280", Offset = "0xBDA680", VA = "0x180BDB280")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public HouseAccount(HouseAccount other)
			{
			}

			[Token(Token = "0x6006F49")]
			[Address(RVA = "0xBDADA0", Offset = "0xBDA1A0", VA = "0x180BDADA0", Slot = "10")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public HouseAccount Clone()
			{
				return null;
			}

			[Token(Token = "0x6006F4E")]
			[Address(RVA = "0xBDAEE0", Offset = "0xBDA2E0", VA = "0x180BDAEE0", Slot = "0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6006F4F")]
			[Address(RVA = "0x96C3C0", Offset = "0x96B7C0", VA = "0x18096C3C0", Slot = "9")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool Equals(HouseAccount other)
			{
				return default(bool);
			}

			[Token(Token = "0x6006F50")]
			[Address(RVA = "0x96C500", Offset = "0x96B900", VA = "0x18096C500", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6006F51")]
			[Address(RVA = "0xBDB120", Offset = "0xBDA520", VA = "0x180BDB120", Slot = "3")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6006F52")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6006F53")]
			[Address(RVA = "0x96CB10", Offset = "0x96BF10", VA = "0x18096CB10", Slot = "12")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6006F54")]
			[Address(RVA = "0xBDACE0", Offset = "0xBDA0E0", VA = "0x180BDACE0", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6006F55")]
			[Address(RVA = "0xBDAFA0", Offset = "0xBDA3A0", VA = "0x180BDAFA0", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(HouseAccount other)
			{
			}

			[Token(Token = "0x6006F56")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6006F57")]
			[Address(RVA = "0xBDB460", Offset = "0xBDA860", VA = "0x180BDB460", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}

		[Token(Token = "0x2000AA5")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class HouseOnMap : IMessage<HouseOnMap>, IMessage, IEquatable<HouseOnMap>, IDeepCloneable<HouseOnMap>, IBufferMessage
		{
			[Token(Token = "0x40026E7")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<HouseOnMap> _parser;

			[Token(Token = "0x40026E8")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x40026E9")]
			public const int DoorsOnMapFieldNumber = 1;

			[Token(Token = "0x40026EA")]
			[FieldOffset(Offset = "0x8")]
			private static readonly FieldCodec<int> _repeated_doorsOnMap_codec;

			[Token(Token = "0x40026EB")]
			[FieldOffset(Offset = "0x18")]
			private readonly RepeatedField<int> doorsOnMap_;

			[Token(Token = "0x40026EC")]
			public const int HousesInformationFieldNumber = 2;

			[Token(Token = "0x40026ED")]
			[FieldOffset(Offset = "0x10")]
			private static readonly FieldCodec<HouseInstance> _repeated_housesInformation_codec;

			[Token(Token = "0x40026EE")]
			[FieldOffset(Offset = "0x20")]
			private readonly RepeatedField<HouseInstance> housesInformation_;

			[Token(Token = "0x17001845")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<HouseOnMap> Parser
			{
				[Token(Token = "0x6006F5C")]
				[Address(RVA = "0xBDED00", Offset = "0xBDE100", VA = "0x180BDED00")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001846")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6006F5D")]
				[Address(RVA = "0xBDEC80", Offset = "0xBDE080", VA = "0x180BDEC80")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001847")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6006F5E")]
				[Address(RVA = "0xBDEFC0", Offset = "0xBDE3C0", VA = "0x180BDEFC0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001848")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public RepeatedField<int> DoorsOnMap
			{
				[Token(Token = "0x6006F62")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001849")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public RepeatedField<HouseInstance> HousesInformation
			{
				[Token(Token = "0x6006F63")]
				[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6006F5F")]
			[Address(RVA = "0xBDEB00", Offset = "0xBDDF00", VA = "0x180BDEB00")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public HouseOnMap()
			{
			}

			[Token(Token = "0x6006F60")]
			[Address(RVA = "0xBDEBC0", Offset = "0xBDDFC0", VA = "0x180BDEBC0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public HouseOnMap(HouseOnMap other)
			{
			}

			[Token(Token = "0x6006F61")]
			[Address(RVA = "0xBDE570", Offset = "0xBDD970", VA = "0x180BDE570", Slot = "10")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public HouseOnMap Clone()
			{
				return null;
			}

			[Token(Token = "0x6006F64")]
			[Address(RVA = "0xBDE720", Offset = "0xBDDB20", VA = "0x180BDE720", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6006F65")]
			[Address(RVA = "0xBDE660", Offset = "0xBDDA60", VA = "0x180BDE660", Slot = "9")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool Equals(HouseOnMap other)
			{
				return default(bool);
			}

			[Token(Token = "0x6006F66")]
			[Address(RVA = "0x943E20", Offset = "0x943220", VA = "0x180943E20", Slot = "2")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6006F67")]
			[Address(RVA = "0xBDE8C0", Offset = "0xBDDCC0", VA = "0x180BDE8C0", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6006F68")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6006F69")]
			[Address(RVA = "0xBDEED0", Offset = "0xBDE2D0", VA = "0x180BDEED0", Slot = "12")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6006F6A")]
			[Address(RVA = "0xBDE490", Offset = "0xBDD890", VA = "0x180BDE490", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6006F6B")]
			[Address(RVA = "0xBDE820", Offset = "0xBDDC20", VA = "0x180BDE820", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(HouseOnMap other)
			{
			}

			[Token(Token = "0x6006F6C")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6006F6D")]
			[Address(RVA = "0xBDED50", Offset = "0xBDE150", VA = "0x180BDED50", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}

		[Token(Token = "0x2000AA7")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class HouseInside : IMessage<HouseInside>, IMessage, IEquatable<HouseInside>, IDeepCloneable<HouseInside>, IBufferMessage
		{
			[Token(Token = "0x40026F0")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<HouseInside> _parser;

			[Token(Token = "0x40026F1")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x40026F2")]
			public const int HouseInformationFieldNumber = 1;

			[Token(Token = "0x40026F3")]
			[FieldOffset(Offset = "0x18")]
			private HouseInstance houseInformation_;

			[Token(Token = "0x40026F4")]
			public const int CoordinatesFieldNumber = 2;

			[Token(Token = "0x40026F5")]
			[FieldOffset(Offset = "0x20")]
			private MapCoordinates coordinates_;

			[Token(Token = "0x1700184A")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageParser<HouseInside> Parser
			{
				[Token(Token = "0x6006F72")]
				[Address(RVA = "0xBDCC80", Offset = "0xBDC080", VA = "0x180BDCC80")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700184B")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6006F73")]
				[Address(RVA = "0xBDCC00", Offset = "0xBDC000", VA = "0x180BDCC00")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700184C")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6006F74")]
				[Address(RVA = "0xBDCE20", Offset = "0xBDC220", VA = "0x180BDCE20", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700184D")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public HouseInstance HouseInformation
			{
				[Token(Token = "0x6006F78")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return null;
				}
				[Token(Token = "0x6006F79")]
				[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
				set
				{
				}
			}

			[Token(Token = "0x1700184E")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public MapCoordinates Coordinates
			{
				[Token(Token = "0x6006F7A")]
				[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
				get
				{
					return null;
				}
				[Token(Token = "0x6006F7B")]
				[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
				set
				{
				}
			}

			[Token(Token = "0x6006F75")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public HouseInside()
			{
			}

			[Token(Token = "0x6006F76")]
			[Address(RVA = "0xBDCB00", Offset = "0xBDBF00", VA = "0x180BDCB00")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public HouseInside(HouseInside other)
			{
			}

			[Token(Token = "0x6006F77")]
			[Address(RVA = "0xBDC650", Offset = "0xBDBA50", VA = "0x180BDC650", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public HouseInside Clone()
			{
				return null;
			}

			[Token(Token = "0x6006F7C")]
			[Address(RVA = "0xBDC780", Offset = "0xBDBB80", VA = "0x180BDC780", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6006F7D")]
			[Address(RVA = "0x96C3C0", Offset = "0x96B7C0", VA = "0x18096C3C0", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(HouseInside other)
			{
				return default(bool);
			}

			[Token(Token = "0x6006F7E")]
			[Address(RVA = "0x96C500", Offset = "0x96B900", VA = "0x18096C500", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6006F7F")]
			[Address(RVA = "0xBDC9A0", Offset = "0xBDBDA0", VA = "0x180BDC9A0", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6006F80")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6006F81")]
			[Address(RVA = "0x96CB10", Offset = "0x96BF10", VA = "0x18096CB10", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6006F82")]
			[Address(RVA = "0xBDC590", Offset = "0xBDB990", VA = "0x180BDC590", Slot = "7")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6006F83")]
			[Address(RVA = "0xBDC840", Offset = "0xBDBC40", VA = "0x180BDC840", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(HouseInside other)
			{
			}

			[Token(Token = "0x6006F84")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6006F85")]
			[Address(RVA = "0xBDCCD0", Offset = "0xBDC0D0", VA = "0x180BDCCD0", Slot = "11")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}

		[Token(Token = "0x2000AA9")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class HouseGuild : IMessage<HouseGuild>, IMessage, IEquatable<HouseGuild>, IDeepCloneable<HouseGuild>, IBufferMessage
		{
			[Token(Token = "0x40026F7")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<HouseGuild> _parser;

			[Token(Token = "0x40026F8")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x40026F9")]
			public const int HouseInformationFieldNumber = 1;

			[Token(Token = "0x40026FA")]
			[FieldOffset(Offset = "0x18")]
			private HouseInstance houseInformation_;

			[Token(Token = "0x40026FB")]
			public const int CoordinatesFieldNumber = 2;

			[Token(Token = "0x40026FC")]
			[FieldOffset(Offset = "0x20")]
			private MapExtendedCoordinates coordinates_;

			[Token(Token = "0x40026FD")]
			public const int SkillsIdFieldNumber = 3;

			[Token(Token = "0x40026FE")]
			[FieldOffset(Offset = "0x8")]
			private static readonly FieldCodec<int> _repeated_skillsId_codec;

			[Token(Token = "0x40026FF")]
			[FieldOffset(Offset = "0x28")]
			private readonly RepeatedField<int> skillsId_;

			[Token(Token = "0x4002700")]
			public const int GuildShareParamsFieldNumber = 4;

			[Token(Token = "0x4002701")]
			[FieldOffset(Offset = "0x30")]
			private long guildShareParams_;

			[Token(Token = "0x1700184F")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageParser<HouseGuild> Parser
			{
				[Token(Token = "0x6006F8A")]
				[Address(RVA = "0xBDC170", Offset = "0xBDB570", VA = "0x180BDC170")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001850")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6006F8B")]
				[Address(RVA = "0xBDC0F0", Offset = "0xBDB4F0", VA = "0x180BDC0F0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001851")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6006F8C")]
				[Address(RVA = "0xBDC4E0", Offset = "0xBDB8E0", VA = "0x180BDC4E0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001852")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public HouseInstance HouseInformation
			{
				[Token(Token = "0x6006F90")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return null;
				}
				[Token(Token = "0x6006F91")]
				[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
				set
				{
				}
			}

			[Token(Token = "0x17001853")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public MapExtendedCoordinates Coordinates
			{
				[Token(Token = "0x6006F92")]
				[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
				get
				{
					return null;
				}
				[Token(Token = "0x6006F93")]
				[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
				set
				{
				}
			}

			[Token(Token = "0x17001854")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public RepeatedField<int> SkillsId
			{
				[Token(Token = "0x6006F94")]
				[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001855")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public long GuildShareParams
			{
				[Token(Token = "0x6006F95")]
				[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x6006F96")]
				[Address(RVA = "0x952BB0", Offset = "0x951FB0", VA = "0x180952BB0")]
				set
				{
				}
			}

			[Token(Token = "0x6006F8D")]
			[Address(RVA = "0xBDC070", Offset = "0xBDB470", VA = "0x180BDC070")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public HouseGuild()
			{
			}

			[Token(Token = "0x6006F8E")]
			[Address(RVA = "0xBDBF10", Offset = "0xBDB310", VA = "0x180BDBF10")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public HouseGuild(HouseGuild other)
			{
			}

			[Token(Token = "0x6006F8F")]
			[Address(RVA = "0xBDB7A0", Offset = "0xBDABA0", VA = "0x180BDB7A0", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public HouseGuild Clone()
			{
				return null;
			}

			[Token(Token = "0x6006F97")]
			[Address(RVA = "0xBDB9F0", Offset = "0xBDADF0", VA = "0x180BDB9F0", Slot = "0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6006F98")]
			[Address(RVA = "0xBDB930", Offset = "0xBDAD30", VA = "0x180BDB930", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(HouseGuild other)
			{
				return default(bool);
			}

			[Token(Token = "0x6006F99")]
			[Address(RVA = "0xBDBB00", Offset = "0xBDAF00", VA = "0x180BDBB00", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6006F9A")]
			[Address(RVA = "0xBDBD80", Offset = "0xBDB180", VA = "0x180BDBD80", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6006F9B")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6006F9C")]
			[Address(RVA = "0xBDC3C0", Offset = "0xBDB7C0", VA = "0x180BDC3C0", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6006F9D")]
			[Address(RVA = "0xBDB660", Offset = "0xBDAA60", VA = "0x180BDB660", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6006F9E")]
			[Address(RVA = "0xBDBBD0", Offset = "0xBDAFD0", VA = "0x180BDBBD0", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(HouseGuild other)
			{
			}

			[Token(Token = "0x6006F9F")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6006FA0")]
			[Address(RVA = "0xBDC1C0", Offset = "0xBDB5C0", VA = "0x180BDC1C0", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x40026CE")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<House> _parser;

	[Token(Token = "0x40026CF")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40026D0")]
	public const int HouseIdFieldNumber = 1;

	[Token(Token = "0x40026D1")]
	[FieldOffset(Offset = "0x18")]
	private int houseId_;

	[Token(Token = "0x40026D2")]
	public const int ModelIdFieldNumber = 2;

	[Token(Token = "0x40026D3")]
	[FieldOffset(Offset = "0x1C")]
	private int modelId_;

	[Token(Token = "0x40026D4")]
	public const int HouseAccountFieldNumber = 3;

	[Token(Token = "0x40026D5")]
	public const int HouseOnMapFieldNumber = 4;

	[Token(Token = "0x40026D6")]
	public const int HouseInsideFieldNumber = 5;

	[Token(Token = "0x40026D7")]
	public const int HouseGuildFieldNumber = 6;

	[Token(Token = "0x40026D8")]
	[FieldOffset(Offset = "0x20")]
	private object information_;

	[Token(Token = "0x40026D9")]
	[FieldOffset(Offset = "0x28")]
	private InformationOneofCase informationCase_;

	[Token(Token = "0x17001836")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<House> Parser
	{
		[Token(Token = "0x6006F25")]
		[Address(RVA = "0xBE03E0", Offset = "0xBDF7E0", VA = "0x180BE03E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001837")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6006F26")]
		[Address(RVA = "0xBE01B0", Offset = "0xBDF5B0", VA = "0x180BE01B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001838")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6006F27")]
		[Address(RVA = "0xBE0940", Offset = "0xBDFD40", VA = "0x180BE0940", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001839")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int HouseId
	{
		[Token(Token = "0x6006F2B")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006F2C")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x1700183A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ModelId
	{
		[Token(Token = "0x6006F2D")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006F2E")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x1700183B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.HouseAccount HouseAccount
	{
		[Token(Token = "0x6006F2F")]
		[Address(RVA = "0xBE0260", Offset = "0xBDF660", VA = "0x180BE0260")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006F30")]
		[Address(RVA = "0x926550", Offset = "0x925950", VA = "0x180926550")]
		set
		{
		}
	}

	[Token(Token = "0x1700183C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.HouseOnMap HouseOnMap
	{
		[Token(Token = "0x6006F31")]
		[Address(RVA = "0xBE0380", Offset = "0xBDF780", VA = "0x180BE0380")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006F32")]
		[Address(RVA = "0x926610", Offset = "0x925A10", VA = "0x180926610")]
		set
		{
		}
	}

	[Token(Token = "0x1700183D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.HouseInside HouseInside
	{
		[Token(Token = "0x6006F33")]
		[Address(RVA = "0xBE0320", Offset = "0xBDF720", VA = "0x180BE0320")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006F34")]
		[Address(RVA = "0x9264D0", Offset = "0x9258D0", VA = "0x1809264D0")]
		set
		{
		}
	}

	[Token(Token = "0x1700183E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.HouseGuild HouseGuild
	{
		[Token(Token = "0x6006F35")]
		[Address(RVA = "0xBE02C0", Offset = "0xBDF6C0", VA = "0x180BE02C0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006F36")]
		[Address(RVA = "0x9265D0", Offset = "0x9259D0", VA = "0x1809265D0")]
		set
		{
		}
	}

	[Token(Token = "0x1700183F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public InformationOneofCase InformationCase
	{
		[Token(Token = "0x6006F37")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(InformationOneofCase);
		}
	}

	[Token(Token = "0x6006F28")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public House()
	{
	}

	[Token(Token = "0x6006F29")]
	[Address(RVA = "0xBDFC40", Offset = "0xBDF040", VA = "0x180BDFC40")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public House(House other)
	{
	}

	[Token(Token = "0x6006F2A")]
	[Address(RVA = "0xBDF2F0", Offset = "0xBDE6F0", VA = "0x180BDF2F0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public House Clone()
	{
		return null;
	}

	[Token(Token = "0x6006F38")]
	[Address(RVA = "0x9247A0", Offset = "0x923BA0", VA = "0x1809247A0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearInformation()
	{
	}

	[Token(Token = "0x6006F39")]
	[Address(RVA = "0xBDF350", Offset = "0xBDE750", VA = "0x180BDF350", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006F3A")]
	[Address(RVA = "0xBDF4C0", Offset = "0xBDE8C0", VA = "0x180BDF4C0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(House other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006F3B")]
	[Address(RVA = "0xBDF600", Offset = "0xBDEA00", VA = "0x180BDF600", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6006F3C")]
	[Address(RVA = "0xBDFAE0", Offset = "0xBDEEE0", VA = "0x180BDFAE0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6006F3D")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6006F3E")]
	[Address(RVA = "0xBE0710", Offset = "0xBDFB10", VA = "0x180BE0710", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6006F3F")]
	[Address(RVA = "0xBDF070", Offset = "0xBDE470", VA = "0x180BDF070", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6006F40")]
	[Address(RVA = "0xBDF840", Offset = "0xBDEC40", VA = "0x180BDF840", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(House other)
	{
	}

	[Token(Token = "0x6006F41")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6006F42")]
	[Address(RVA = "0xBE0430", Offset = "0xBDF830", VA = "0x180BE0430", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
