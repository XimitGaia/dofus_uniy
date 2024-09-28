using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Treasure.Hunt;

[Token(Token = "0x2000030")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class TreasureHuntEvent : IMessage<TreasureHuntEvent>, IMessage, IEquatable<TreasureHuntEvent>, IDeepCloneable<TreasureHuntEvent>, IBufferMessage
{
	[Token(Token = "0x2000031")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x2000032")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class TreasureHuntStep : IMessage<TreasureHuntStep>, IMessage, IEquatable<TreasureHuntStep>, IDeepCloneable<TreasureHuntStep>, IBufferMessage
		{
			[Token(Token = "0x2000033")]
			public enum StepOneofCase
			{
				[Token(Token = "0x40000B3")]
				None,
				[Token(Token = "0x40000B4")]
				FollowDirectionToPoi,
				[Token(Token = "0x40000B5")]
				FollowDirectionToHint,
				[Token(Token = "0x40000B6")]
				FollowDirection,
				[Token(Token = "0x40000B7")]
				Fight,
				[Token(Token = "0x40000B8")]
				Dig
			}

			[Token(Token = "0x2000034")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static class Types
			{
				[Token(Token = "0x2000035")]
				[DebuggerDisplay("{ToString(),nq}")]
				public sealed class FollowDirectionToPOI : IMessage<FollowDirectionToPOI>, IMessage, IEquatable<FollowDirectionToPOI>, IDeepCloneable<FollowDirectionToPOI>, IBufferMessage
				{
					[Token(Token = "0x40000B9")]
					[FieldOffset(Offset = "0x0")]
					private static readonly MessageParser<FollowDirectionToPOI> _parser;

					[Token(Token = "0x40000BA")]
					[FieldOffset(Offset = "0x10")]
					private UnknownFieldSet _unknownFields;

					[Token(Token = "0x40000BB")]
					public const int DirectionFieldNumber = 1;

					[Token(Token = "0x40000BC")]
					[FieldOffset(Offset = "0x18")]
					private Direction direction_;

					[Token(Token = "0x40000BD")]
					public const int PoiLabelIdFieldNumber = 2;

					[Token(Token = "0x40000BE")]
					[FieldOffset(Offset = "0x1C")]
					private int poiLabelId_;

					[Token(Token = "0x17000062")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public static MessageParser<FollowDirectionToPOI> Parser
					{
						[Token(Token = "0x60001AB")]
						[Address(RVA = "0x93B3C0", Offset = "0x93A7C0", VA = "0x18093B3C0")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x17000063")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public static MessageDescriptor Descriptor
					{
						[Token(Token = "0x60001AC")]
						[Address(RVA = "0x93B340", Offset = "0x93A740", VA = "0x18093B340")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x17000064")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
					{
						[Token(Token = "0x60001AD")]
						[Address(RVA = "0x93B410", Offset = "0x93A810", VA = "0x18093B410", Slot = "8")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x17000065")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public Direction Direction
					{
						[Token(Token = "0x60001B1")]
						[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
						get
						{
							return default(Direction);
						}
						[Token(Token = "0x60001B2")]
						[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
						set
						{
						}
					}

					[Token(Token = "0x17000066")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public int PoiLabelId
					{
						[Token(Token = "0x60001B3")]
						[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
						get
						{
							return default(int);
						}
						[Token(Token = "0x60001B4")]
						[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
						set
						{
						}
					}

					[Token(Token = "0x60001AE")]
					[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public FollowDirectionToPOI()
					{
					}

					[Token(Token = "0x60001AF")]
					[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public FollowDirectionToPOI(FollowDirectionToPOI other)
					{
					}

					[Token(Token = "0x60001B0")]
					[Address(RVA = "0x93B0C0", Offset = "0x93A4C0", VA = "0x18093B0C0", Slot = "10")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public FollowDirectionToPOI Clone()
					{
						return null;
					}

					[Token(Token = "0x60001B5")]
					[Address(RVA = "0x93B150", Offset = "0x93A550", VA = "0x18093B150", Slot = "0")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public override bool Equals(object other)
					{
						return default(bool);
					}

					[Token(Token = "0x60001B6")]
					[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public bool Equals(FollowDirectionToPOI other)
					{
						return default(bool);
					}

					[Token(Token = "0x60001B7")]
					[Address(RVA = "0x93AAA0", Offset = "0x939EA0", VA = "0x18093AAA0", Slot = "2")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public override int GetHashCode()
					{
						return default(int);
					}

					[Token(Token = "0x60001B8")]
					[Address(RVA = "0x93B1E0", Offset = "0x93A5E0", VA = "0x18093B1E0", Slot = "3")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override string ToString()
					{
						return null;
					}

					[Token(Token = "0x60001B9")]
					[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void WriteTo(CodedOutputStream output)
					{
					}

					[Token(Token = "0x60001BA")]
					[Address(RVA = "0x93AED0", Offset = "0x93A2D0", VA = "0x18093AED0", Slot = "12")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
					{
					}

					[Token(Token = "0x60001BB")]
					[Address(RVA = "0x93B000", Offset = "0x93A400", VA = "0x18093B000", Slot = "7")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public int CalculateSize()
					{
						return default(int);
					}

					[Token(Token = "0x60001BC")]
					[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void MergeFrom(FollowDirectionToPOI other)
					{
					}

					[Token(Token = "0x60001BD")]
					[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void MergeFrom(CodedInputStream input)
					{
					}

					[Token(Token = "0x60001BE")]
					[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
					{
					}
				}

				[Token(Token = "0x2000037")]
				[DebuggerDisplay("{ToString(),nq}")]
				public sealed class FollowDirectionToHint : IMessage<FollowDirectionToHint>, IMessage, IEquatable<FollowDirectionToHint>, IDeepCloneable<FollowDirectionToHint>, IBufferMessage
				{
					[Token(Token = "0x40000C0")]
					[FieldOffset(Offset = "0x0")]
					private static readonly MessageParser<FollowDirectionToHint> _parser;

					[Token(Token = "0x40000C1")]
					[FieldOffset(Offset = "0x10")]
					private UnknownFieldSet _unknownFields;

					[Token(Token = "0x40000C2")]
					public const int DirectionFieldNumber = 1;

					[Token(Token = "0x40000C3")]
					[FieldOffset(Offset = "0x18")]
					private Direction direction_;

					[Token(Token = "0x40000C4")]
					public const int NpcIdFieldNumber = 2;

					[Token(Token = "0x40000C5")]
					[FieldOffset(Offset = "0x1C")]
					private int npcId_;

					[Token(Token = "0x17000067")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public static MessageParser<FollowDirectionToHint> Parser
					{
						[Token(Token = "0x60001C3")]
						[Address(RVA = "0x93ADD0", Offset = "0x93A1D0", VA = "0x18093ADD0")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x17000068")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public static MessageDescriptor Descriptor
					{
						[Token(Token = "0x60001C4")]
						[Address(RVA = "0x93AD50", Offset = "0x93A150", VA = "0x18093AD50")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x17000069")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
					{
						[Token(Token = "0x60001C5")]
						[Address(RVA = "0x93AF50", Offset = "0x93A350", VA = "0x18093AF50", Slot = "8")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x1700006A")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public Direction Direction
					{
						[Token(Token = "0x60001C9")]
						[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
						get
						{
							return default(Direction);
						}
						[Token(Token = "0x60001CA")]
						[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
						set
						{
						}
					}

					[Token(Token = "0x1700006B")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public int NpcId
					{
						[Token(Token = "0x60001CB")]
						[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
						get
						{
							return default(int);
						}
						[Token(Token = "0x60001CC")]
						[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
						set
						{
						}
					}

					[Token(Token = "0x60001C6")]
					[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public FollowDirectionToHint()
					{
					}

					[Token(Token = "0x60001C7")]
					[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public FollowDirectionToHint(FollowDirectionToHint other)
					{
					}

					[Token(Token = "0x60001C8")]
					[Address(RVA = "0x93A950", Offset = "0x939D50", VA = "0x18093A950", Slot = "10")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public FollowDirectionToHint Clone()
					{
						return null;
					}

					[Token(Token = "0x60001CD")]
					[Address(RVA = "0x93A9E0", Offset = "0x939DE0", VA = "0x18093A9E0", Slot = "0")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public override bool Equals(object other)
					{
						return default(bool);
					}

					[Token(Token = "0x60001CE")]
					[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public bool Equals(FollowDirectionToHint other)
					{
						return default(bool);
					}

					[Token(Token = "0x60001CF")]
					[Address(RVA = "0x93AAA0", Offset = "0x939EA0", VA = "0x18093AAA0", Slot = "2")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override int GetHashCode()
					{
						return default(int);
					}

					[Token(Token = "0x60001D0")]
					[Address(RVA = "0x93AB90", Offset = "0x939F90", VA = "0x18093AB90", Slot = "3")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public override string ToString()
					{
						return null;
					}

					[Token(Token = "0x60001D1")]
					[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public void WriteTo(CodedOutputStream output)
					{
					}

					[Token(Token = "0x60001D2")]
					[Address(RVA = "0x93AED0", Offset = "0x93A2D0", VA = "0x18093AED0", Slot = "12")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
					{
					}

					[Token(Token = "0x60001D3")]
					[Address(RVA = "0x93A890", Offset = "0x939C90", VA = "0x18093A890", Slot = "7")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public int CalculateSize()
					{
						return default(int);
					}

					[Token(Token = "0x60001D4")]
					[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public void MergeFrom(FollowDirectionToHint other)
					{
					}

					[Token(Token = "0x60001D5")]
					[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void MergeFrom(CodedInputStream input)
					{
					}

					[Token(Token = "0x60001D6")]
					[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
					{
					}
				}

				[Token(Token = "0x2000039")]
				[DebuggerDisplay("{ToString(),nq}")]
				public sealed class FollowDirection : IMessage<FollowDirection>, IMessage, IEquatable<FollowDirection>, IDeepCloneable<FollowDirection>, IBufferMessage
				{
					[Token(Token = "0x40000C7")]
					[FieldOffset(Offset = "0x0")]
					private static readonly MessageParser<FollowDirection> _parser;

					[Token(Token = "0x40000C8")]
					[FieldOffset(Offset = "0x10")]
					private UnknownFieldSet _unknownFields;

					[Token(Token = "0x40000C9")]
					public const int DirectionFieldNumber = 1;

					[Token(Token = "0x40000CA")]
					[FieldOffset(Offset = "0x18")]
					private Direction direction_;

					[Token(Token = "0x40000CB")]
					public const int MapCountFieldNumber = 2;

					[Token(Token = "0x40000CC")]
					[FieldOffset(Offset = "0x1C")]
					private int mapCount_;

					[Token(Token = "0x1700006C")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public static MessageParser<FollowDirection> Parser
					{
						[Token(Token = "0x60001DB")]
						[Address(RVA = "0x93B880", Offset = "0x93AC80", VA = "0x18093B880")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x1700006D")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public static MessageDescriptor Descriptor
					{
						[Token(Token = "0x60001DC")]
						[Address(RVA = "0x93B800", Offset = "0x93AC00", VA = "0x18093B800")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x1700006E")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
					{
						[Token(Token = "0x60001DD")]
						[Address(RVA = "0x93B8D0", Offset = "0x93ACD0", VA = "0x18093B8D0", Slot = "8")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x1700006F")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public Direction Direction
					{
						[Token(Token = "0x60001E1")]
						[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
						get
						{
							return default(Direction);
						}
						[Token(Token = "0x60001E2")]
						[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
						set
						{
						}
					}

					[Token(Token = "0x17000070")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public int MapCount
					{
						[Token(Token = "0x60001E3")]
						[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
						get
						{
							return default(int);
						}
						[Token(Token = "0x60001E4")]
						[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
						set
						{
						}
					}

					[Token(Token = "0x60001DE")]
					[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public FollowDirection()
					{
					}

					[Token(Token = "0x60001DF")]
					[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public FollowDirection(FollowDirection other)
					{
					}

					[Token(Token = "0x60001E0")]
					[Address(RVA = "0x93B580", Offset = "0x93A980", VA = "0x18093B580", Slot = "10")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public FollowDirection Clone()
					{
						return null;
					}

					[Token(Token = "0x60001E5")]
					[Address(RVA = "0x93B610", Offset = "0x93AA10", VA = "0x18093B610", Slot = "0")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override bool Equals(object other)
					{
						return default(bool);
					}

					[Token(Token = "0x60001E6")]
					[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public bool Equals(FollowDirection other)
					{
						return default(bool);
					}

					[Token(Token = "0x60001E7")]
					[Address(RVA = "0x93AAA0", Offset = "0x939EA0", VA = "0x18093AAA0", Slot = "2")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public override int GetHashCode()
					{
						return default(int);
					}

					[Token(Token = "0x60001E8")]
					[Address(RVA = "0x93B6A0", Offset = "0x93AAA0", VA = "0x18093B6A0", Slot = "3")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override string ToString()
					{
						return null;
					}

					[Token(Token = "0x60001E9")]
					[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public void WriteTo(CodedOutputStream output)
					{
					}

					[Token(Token = "0x60001EA")]
					[Address(RVA = "0x93AED0", Offset = "0x93A2D0", VA = "0x18093AED0", Slot = "12")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
					{
					}

					[Token(Token = "0x60001EB")]
					[Address(RVA = "0x93B4C0", Offset = "0x93A8C0", VA = "0x18093B4C0", Slot = "7")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public int CalculateSize()
					{
						return default(int);
					}

					[Token(Token = "0x60001EC")]
					[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public void MergeFrom(FollowDirection other)
					{
					}

					[Token(Token = "0x60001ED")]
					[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void MergeFrom(CodedInputStream input)
					{
					}

					[Token(Token = "0x60001EE")]
					[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
					{
					}
				}

				[Token(Token = "0x200003B")]
				[DebuggerDisplay("{ToString(),nq}")]
				public sealed class Fight : IMessage<Fight>, IMessage, IEquatable<Fight>, IDeepCloneable<Fight>, IBufferMessage
				{
					[Token(Token = "0x40000CE")]
					[FieldOffset(Offset = "0x0")]
					private static readonly MessageParser<Fight> _parser;

					[Token(Token = "0x40000CF")]
					[FieldOffset(Offset = "0x10")]
					private UnknownFieldSet _unknownFields;

					[Token(Token = "0x17000071")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public static MessageParser<Fight> Parser
					{
						[Token(Token = "0x60001F3")]
						[Address(RVA = "0x93A790", Offset = "0x939B90", VA = "0x18093A790")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x17000072")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public static MessageDescriptor Descriptor
					{
						[Token(Token = "0x60001F4")]
						[Address(RVA = "0x93A710", Offset = "0x939B10", VA = "0x18093A710")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x17000073")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
					{
						[Token(Token = "0x60001F5")]
						[Address(RVA = "0x93A7E0", Offset = "0x939BE0", VA = "0x18093A7E0", Slot = "8")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x60001F6")]
					[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public Fight()
					{
					}

					[Token(Token = "0x60001F7")]
					[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public Fight(Fight other)
					{
					}

					[Token(Token = "0x60001F8")]
					[Address(RVA = "0x93A4B0", Offset = "0x9398B0", VA = "0x18093A4B0", Slot = "10")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public Fight Clone()
					{
						return null;
					}

					[Token(Token = "0x60001F9")]
					[Address(RVA = "0x93A530", Offset = "0x939930", VA = "0x18093A530", Slot = "0")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override bool Equals(object other)
					{
						return default(bool);
					}

					[Token(Token = "0x60001FA")]
					[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public bool Equals(Fight other)
					{
						return default(bool);
					}

					[Token(Token = "0x60001FB")]
					[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override int GetHashCode()
					{
						return default(int);
					}

					[Token(Token = "0x60001FC")]
					[Address(RVA = "0x93A5B0", Offset = "0x9399B0", VA = "0x18093A5B0", Slot = "3")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override string ToString()
					{
						return null;
					}

					[Token(Token = "0x60001FD")]
					[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void WriteTo(CodedOutputStream output)
					{
					}

					[Token(Token = "0x60001FE")]
					[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
					{
					}

					[Token(Token = "0x60001FF")]
					[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public int CalculateSize()
					{
						return default(int);
					}

					[Token(Token = "0x6000200")]
					[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public void MergeFrom(Fight other)
					{
					}

					[Token(Token = "0x6000201")]
					[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public void MergeFrom(CodedInputStream input)
					{
					}

					[Token(Token = "0x6000202")]
					[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
					{
					}
				}

				[Token(Token = "0x200003D")]
				[DebuggerDisplay("{ToString(),nq}")]
				public sealed class Dig : IMessage<Dig>, IMessage, IEquatable<Dig>, IDeepCloneable<Dig>, IBufferMessage
				{
					[Token(Token = "0x40000D1")]
					[FieldOffset(Offset = "0x0")]
					private static readonly MessageParser<Dig> _parser;

					[Token(Token = "0x40000D2")]
					[FieldOffset(Offset = "0x10")]
					private UnknownFieldSet _unknownFields;

					[Token(Token = "0x17000074")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public static MessageParser<Dig> Parser
					{
						[Token(Token = "0x6000207")]
						[Address(RVA = "0x939C50", Offset = "0x939050", VA = "0x180939C50")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x17000075")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public static MessageDescriptor Descriptor
					{
						[Token(Token = "0x6000208")]
						[Address(RVA = "0x939BD0", Offset = "0x938FD0", VA = "0x180939BD0")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x17000076")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
					{
						[Token(Token = "0x6000209")]
						[Address(RVA = "0x939CA0", Offset = "0x9390A0", VA = "0x180939CA0", Slot = "8")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x600020A")]
					[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public Dig()
					{
					}

					[Token(Token = "0x600020B")]
					[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public Dig(Dig other)
					{
					}

					[Token(Token = "0x600020C")]
					[Address(RVA = "0x939970", Offset = "0x938D70", VA = "0x180939970", Slot = "10")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public Dig Clone()
					{
						return null;
					}

					[Token(Token = "0x600020D")]
					[Address(RVA = "0x9399F0", Offset = "0x938DF0", VA = "0x1809399F0", Slot = "0")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override bool Equals(object other)
					{
						return default(bool);
					}

					[Token(Token = "0x600020E")]
					[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public bool Equals(Dig other)
					{
						return default(bool);
					}

					[Token(Token = "0x600020F")]
					[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public override int GetHashCode()
					{
						return default(int);
					}

					[Token(Token = "0x6000210")]
					[Address(RVA = "0x939A70", Offset = "0x938E70", VA = "0x180939A70", Slot = "3")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public override string ToString()
					{
						return null;
					}

					[Token(Token = "0x6000211")]
					[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public void WriteTo(CodedOutputStream output)
					{
					}

					[Token(Token = "0x6000212")]
					[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
					{
					}

					[Token(Token = "0x6000213")]
					[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public int CalculateSize()
					{
						return default(int);
					}

					[Token(Token = "0x6000214")]
					[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public void MergeFrom(Dig other)
					{
					}

					[Token(Token = "0x6000215")]
					[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void MergeFrom(CodedInputStream input)
					{
					}

					[Token(Token = "0x6000216")]
					[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
					{
					}
				}
			}

			[Token(Token = "0x40000A9")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<TreasureHuntStep> _parser;

			[Token(Token = "0x40000AA")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x40000AB")]
			public const int FollowDirectionToPoiFieldNumber = 1;

			[Token(Token = "0x40000AC")]
			public const int FollowDirectionToHintFieldNumber = 2;

			[Token(Token = "0x40000AD")]
			public const int FollowDirectionFieldNumber = 3;

			[Token(Token = "0x40000AE")]
			public const int FightFieldNumber = 4;

			[Token(Token = "0x40000AF")]
			public const int DigFieldNumber = 5;

			[Token(Token = "0x40000B0")]
			[FieldOffset(Offset = "0x18")]
			private object step_;

			[Token(Token = "0x40000B1")]
			[FieldOffset(Offset = "0x20")]
			private StepOneofCase stepCase_;

			[Token(Token = "0x17000059")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<TreasureHuntStep> Parser
			{
				[Token(Token = "0x600018E")]
				[Address(RVA = "0x94E140", Offset = "0x94D540", VA = "0x18094E140")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700005A")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x600018F")]
				[Address(RVA = "0x94DEE0", Offset = "0x94D2E0", VA = "0x18094DEE0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700005B")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6000190")]
				[Address(RVA = "0x94E7E0", Offset = "0x94DBE0", VA = "0x18094E7E0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700005C")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Types.FollowDirectionToPOI FollowDirectionToPoi
			{
				[Token(Token = "0x6000194")]
				[Address(RVA = "0x94E080", Offset = "0x94D480", VA = "0x18094E080")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000195")]
				[Address(RVA = "0x917DA0", Offset = "0x9171A0", VA = "0x180917DA0")]
				set
				{
				}
			}

			[Token(Token = "0x1700005D")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Types.FollowDirectionToHint FollowDirectionToHint
			{
				[Token(Token = "0x6000196")]
				[Address(RVA = "0x94E020", Offset = "0x94D420", VA = "0x18094E020")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000197")]
				[Address(RVA = "0x917DE0", Offset = "0x9171E0", VA = "0x180917DE0")]
				set
				{
				}
			}

			[Token(Token = "0x1700005E")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Types.FollowDirection FollowDirection
			{
				[Token(Token = "0x6000198")]
				[Address(RVA = "0x94E0E0", Offset = "0x94D4E0", VA = "0x18094E0E0")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000199")]
				[Address(RVA = "0x919620", Offset = "0x918A20", VA = "0x180919620")]
				set
				{
				}
			}

			[Token(Token = "0x1700005F")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Types.Fight Fight
			{
				[Token(Token = "0x600019A")]
				[Address(RVA = "0x94DFC0", Offset = "0x94D3C0", VA = "0x18094DFC0")]
				get
				{
					return null;
				}
				[Token(Token = "0x600019B")]
				[Address(RVA = "0x94E860", Offset = "0x94DC60", VA = "0x18094E860")]
				set
				{
				}
			}

			[Token(Token = "0x17000060")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public Types.Dig Dig
			{
				[Token(Token = "0x600019C")]
				[Address(RVA = "0x94DF60", Offset = "0x94D360", VA = "0x18094DF60")]
				get
				{
					return null;
				}
				[Token(Token = "0x600019D")]
				[Address(RVA = "0x94E820", Offset = "0x94DC20", VA = "0x18094E820")]
				set
				{
				}
			}

			[Token(Token = "0x17000061")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public StepOneofCase StepCase
			{
				[Token(Token = "0x600019E")]
				[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
				get
				{
					return default(StepOneofCase);
				}
			}

			[Token(Token = "0x6000191")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public TreasureHuntStep()
			{
			}

			[Token(Token = "0x6000192")]
			[Address(RVA = "0x94DBA0", Offset = "0x94CFA0", VA = "0x18094DBA0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public TreasureHuntStep(TreasureHuntStep other)
			{
			}

			[Token(Token = "0x6000193")]
			[Address(RVA = "0x94D250", Offset = "0x94C650", VA = "0x18094D250", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public TreasureHuntStep Clone()
			{
				return null;
			}

			[Token(Token = "0x600019F")]
			[Address(RVA = "0x916DD0", Offset = "0x9161D0", VA = "0x180916DD0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void ClearStep()
			{
			}

			[Token(Token = "0x60001A0")]
			[Address(RVA = "0x94D470", Offset = "0x94C870", VA = "0x18094D470", Slot = "0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x60001A1")]
			[Address(RVA = "0x94D2B0", Offset = "0x94C6B0", VA = "0x18094D2B0", Slot = "9")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool Equals(TreasureHuntStep other)
			{
				return default(bool);
			}

			[Token(Token = "0x60001A2")]
			[Address(RVA = "0x94D4D0", Offset = "0x94C8D0", VA = "0x18094D4D0", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x60001A3")]
			[Address(RVA = "0x94DA40", Offset = "0x94CE40", VA = "0x18094DA40", Slot = "3")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x60001A4")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x60001A5")]
			[Address(RVA = "0x94E590", Offset = "0x94D990", VA = "0x18094E590", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x60001A6")]
			[Address(RVA = "0x94CFC0", Offset = "0x94C3C0", VA = "0x18094CFC0", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x60001A7")]
			[Address(RVA = "0x94D750", Offset = "0x94CB50", VA = "0x18094D750", Slot = "4")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(TreasureHuntStep other)
			{
			}

			[Token(Token = "0x60001A8")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x60001A9")]
			[Address(RVA = "0x94E190", Offset = "0x94D590", VA = "0x18094E190", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}

		[Token(Token = "0x2000040")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class TreasureHuntFlag : IMessage<TreasureHuntFlag>, IMessage, IEquatable<TreasureHuntFlag>, IDeepCloneable<TreasureHuntFlag>, IBufferMessage
		{
			[Token(Token = "0x2000041")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static class Types
			{
				[Token(Token = "0x2000042")]
				public enum FlagState
				{
					[Token(Token = "0x40000DC")]
					[OriginalName("UNKNOWN")]
					Unknown,
					[Token(Token = "0x40000DD")]
					[OriginalName("OK")]
					Ok,
					[Token(Token = "0x40000DE")]
					[OriginalName("WRONG")]
					Wrong
				}
			}

			[Token(Token = "0x40000D5")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<TreasureHuntFlag> _parser;

			[Token(Token = "0x40000D6")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x40000D7")]
			public const int MapIdFieldNumber = 1;

			[Token(Token = "0x40000D8")]
			[FieldOffset(Offset = "0x18")]
			private long mapId_;

			[Token(Token = "0x40000D9")]
			public const int StateFieldNumber = 2;

			[Token(Token = "0x40000DA")]
			[FieldOffset(Offset = "0x20")]
			private Types.FlagState state_;

			[Token(Token = "0x17000077")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageParser<TreasureHuntFlag> Parser
			{
				[Token(Token = "0x600021E")]
				[Address(RVA = "0x948DD0", Offset = "0x9481D0", VA = "0x180948DD0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000078")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x600021F")]
				[Address(RVA = "0x948D50", Offset = "0x948150", VA = "0x180948D50")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000079")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6000220")]
				[Address(RVA = "0x948F50", Offset = "0x948350", VA = "0x180948F50", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007A")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public long MapId
			{
				[Token(Token = "0x6000224")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x6000225")]
				[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
				set
				{
				}
			}

			[Token(Token = "0x1700007B")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Types.FlagState State
			{
				[Token(Token = "0x6000226")]
				[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
				get
				{
					return default(Types.FlagState);
				}
				[Token(Token = "0x6000227")]
				[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
				set
				{
				}
			}

			[Token(Token = "0x6000221")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public TreasureHuntFlag()
			{
			}

			[Token(Token = "0x6000222")]
			[Address(RVA = "0x948CF0", Offset = "0x9480F0", VA = "0x180948CF0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public TreasureHuntFlag(TreasureHuntFlag other)
			{
			}

			[Token(Token = "0x6000223")]
			[Address(RVA = "0x948930", Offset = "0x947D30", VA = "0x180948930", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public TreasureHuntFlag Clone()
			{
				return null;
			}

			[Token(Token = "0x6000228")]
			[Address(RVA = "0x948A00", Offset = "0x947E00", VA = "0x180948A00", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6000229")]
			[Address(RVA = "0x9489C0", Offset = "0x947DC0", VA = "0x1809489C0", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(TreasureHuntFlag other)
			{
				return default(bool);
			}

			[Token(Token = "0x600022A")]
			[Address(RVA = "0x948AA0", Offset = "0x947EA0", VA = "0x180948AA0", Slot = "2")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x600022B")]
			[Address(RVA = "0x948B90", Offset = "0x947F90", VA = "0x180948B90", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x600022C")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x600022D")]
			[Address(RVA = "0x948ED0", Offset = "0x9482D0", VA = "0x180948ED0", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x600022E")]
			[Address(RVA = "0x948870", Offset = "0x947C70", VA = "0x180948870", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x600022F")]
			[Address(RVA = "0x948B30", Offset = "0x947F30", VA = "0x180948B30", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(TreasureHuntFlag other)
			{
			}

			[Token(Token = "0x6000230")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6000231")]
			[Address(RVA = "0x948E20", Offset = "0x948220", VA = "0x180948E20", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x4000095")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<TreasureHuntEvent> _parser;

	[Token(Token = "0x4000096")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000097")]
	public const int QuestTypeFieldNumber = 1;

	[Token(Token = "0x4000098")]
	[FieldOffset(Offset = "0x18")]
	private TreasureHuntType questType_;

	[Token(Token = "0x4000099")]
	public const int StartMapIdFieldNumber = 2;

	[Token(Token = "0x400009A")]
	[FieldOffset(Offset = "0x20")]
	private long startMapId_;

	[Token(Token = "0x400009B")]
	public const int KnownStepsFieldNumber = 3;

	[Token(Token = "0x400009C")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<Types.TreasureHuntStep> _repeated_knownSteps_codec;

	[Token(Token = "0x400009D")]
	[FieldOffset(Offset = "0x28")]
	private readonly RepeatedField<Types.TreasureHuntStep> knownSteps_;

	[Token(Token = "0x400009E")]
	public const int TotalStepCountFieldNumber = 4;

	[Token(Token = "0x400009F")]
	[FieldOffset(Offset = "0x30")]
	private int totalStepCount_;

	[Token(Token = "0x40000A0")]
	public const int CurrentCheckPointFieldNumber = 5;

	[Token(Token = "0x40000A1")]
	[FieldOffset(Offset = "0x34")]
	private int currentCheckPoint_;

	[Token(Token = "0x40000A2")]
	public const int TotalCheckPointFieldNumber = 6;

	[Token(Token = "0x40000A3")]
	[FieldOffset(Offset = "0x38")]
	private int totalCheckPoint_;

	[Token(Token = "0x40000A4")]
	public const int AvailableRetryCountFieldNumber = 7;

	[Token(Token = "0x40000A5")]
	[FieldOffset(Offset = "0x3C")]
	private int availableRetryCount_;

	[Token(Token = "0x40000A6")]
	public const int FlagsFieldNumber = 8;

	[Token(Token = "0x40000A7")]
	[FieldOffset(Offset = "0x10")]
	private static readonly FieldCodec<Types.TreasureHuntFlag> _repeated_flags_codec;

	[Token(Token = "0x40000A8")]
	[FieldOffset(Offset = "0x40")]
	private readonly RepeatedField<Types.TreasureHuntFlag> flags_;

	[Token(Token = "0x1700004E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<TreasureHuntEvent> Parser
	{
		[Token(Token = "0x600016F")]
		[Address(RVA = "0x946C60", Offset = "0x946060", VA = "0x180946C60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700004F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000170")]
		[Address(RVA = "0x946BB0", Offset = "0x945FB0", VA = "0x180946BB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000050")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000171")]
		[Address(RVA = "0x9470B0", Offset = "0x9464B0", VA = "0x1809470B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000051")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TreasureHuntType QuestType
	{
		[Token(Token = "0x6000175")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(TreasureHuntType);
		}
		[Token(Token = "0x6000176")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000052")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long StartMapId
	{
		[Token(Token = "0x6000177")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000178")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000053")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<Types.TreasureHuntStep> KnownSteps
	{
		[Token(Token = "0x6000179")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000054")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int TotalStepCount
	{
		[Token(Token = "0x600017A")]
		[Address(RVA = "0x875C10", Offset = "0x875010", VA = "0x180875C10")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600017B")]
		[Address(RVA = "0x947120", Offset = "0x946520", VA = "0x180947120")]
		set
		{
		}
	}

	[Token(Token = "0x17000055")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CurrentCheckPoint
	{
		[Token(Token = "0x600017C")]
		[Address(RVA = "0x946BA0", Offset = "0x945FA0", VA = "0x180946BA0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600017D")]
		[Address(RVA = "0x947100", Offset = "0x946500", VA = "0x180947100")]
		set
		{
		}
	}

	[Token(Token = "0x17000056")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int TotalCheckPoint
	{
		[Token(Token = "0x600017E")]
		[Address(RVA = "0x8F8300", Offset = "0x8F7700", VA = "0x1808F8300")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600017F")]
		[Address(RVA = "0x947110", Offset = "0x946510", VA = "0x180947110")]
		set
		{
		}
	}

	[Token(Token = "0x17000057")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int AvailableRetryCount
	{
		[Token(Token = "0x6000180")]
		[Address(RVA = "0x946B90", Offset = "0x945F90", VA = "0x180946B90")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000181")]
		[Address(RVA = "0x9470F0", Offset = "0x9464F0", VA = "0x1809470F0")]
		set
		{
		}
	}

	[Token(Token = "0x17000058")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<Types.TreasureHuntFlag> Flags
	{
		[Token(Token = "0x6000182")]
		[Address(RVA = "0x7D6D10", Offset = "0x7D6110", VA = "0x1807D6D10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0x946AD0", Offset = "0x945ED0", VA = "0x180946AD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TreasureHuntEvent()
	{
	}

	[Token(Token = "0x6000173")]
	[Address(RVA = "0x9469E0", Offset = "0x945DE0", VA = "0x1809469E0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TreasureHuntEvent(TreasureHuntEvent other)
	{
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0x9461B0", Offset = "0x9455B0", VA = "0x1809461B0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TreasureHuntEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0x9463C0", Offset = "0x9457C0", VA = "0x1809463C0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0x9462C0", Offset = "0x9456C0", VA = "0x1809462C0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TreasureHuntEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000185")]
	[Address(RVA = "0x946510", Offset = "0x945910", VA = "0x180946510", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000186")]
	[Address(RVA = "0x946730", Offset = "0x945B30", VA = "0x180946730", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000187")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000188")]
	[Address(RVA = "0x946EE0", Offset = "0x9462E0", VA = "0x180946EE0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000189")]
	[Address(RVA = "0x945FA0", Offset = "0x9453A0", VA = "0x180945FA0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600018A")]
	[Address(RVA = "0x946640", Offset = "0x945A40", VA = "0x180946640", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(TreasureHuntEvent other)
	{
	}

	[Token(Token = "0x600018B")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600018C")]
	[Address(RVA = "0x946CB0", Offset = "0x9460B0", VA = "0x180946CB0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
