using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Arena;

[Token(Token = "0x2000BB2")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class SurrenderInfoResponse : IMessage<SurrenderInfoResponse>, IMessage, IEquatable<SurrenderInfoResponse>, IDeepCloneable<SurrenderInfoResponse>, IBufferMessage
{
	[Token(Token = "0x2000BB3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x2000BB4")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class SurrenderResponse : IMessage<SurrenderResponse>, IMessage, IEquatable<SurrenderResponse>, IDeepCloneable<SurrenderResponse>, IBufferMessage
		{
			[Token(Token = "0x2000BB5")]
			public enum ResponseOneofCase
			{
				[Token(Token = "0x4002BB2")]
				None,
				[Token(Token = "0x4002BB3")]
				Accepted,
				[Token(Token = "0x4002BB4")]
				Refused,
				[Token(Token = "0x4002BB5")]
				BeforeTurn,
				[Token(Token = "0x4002BB6")]
				BeforeVote
			}

			[Token(Token = "0x2000BB6")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static class Types
			{
				[Token(Token = "0x2000BB7")]
				[DebuggerDisplay("{ToString(),nq}")]
				public sealed class SurrenderAccepted : IMessage<SurrenderAccepted>, IMessage, IEquatable<SurrenderAccepted>, IDeepCloneable<SurrenderAccepted>, IBufferMessage
				{
					[Token(Token = "0x4002BB7")]
					[FieldOffset(Offset = "0x0")]
					private static readonly MessageParser<SurrenderAccepted> _parser;

					[Token(Token = "0x4002BB8")]
					[FieldOffset(Offset = "0x10")]
					private UnknownFieldSet _unknownFields;

					[Token(Token = "0x17001B24")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public static MessageParser<SurrenderAccepted> Parser
					{
						[Token(Token = "0x6007B3E")]
						[Address(RVA = "0xC38230", Offset = "0xC37630", VA = "0x180C38230")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x17001B25")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public static MessageDescriptor Descriptor
					{
						[Token(Token = "0x6007B3F")]
						[Address(RVA = "0xC381B0", Offset = "0xC375B0", VA = "0x180C381B0")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x17001B26")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
					{
						[Token(Token = "0x6007B40")]
						[Address(RVA = "0xC38280", Offset = "0xC37680", VA = "0x180C38280", Slot = "8")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x6007B41")]
					[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public SurrenderAccepted()
					{
					}

					[Token(Token = "0x6007B42")]
					[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public SurrenderAccepted(SurrenderAccepted other)
					{
					}

					[Token(Token = "0x6007B43")]
					[Address(RVA = "0xC37F50", Offset = "0xC37350", VA = "0x180C37F50", Slot = "10")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public SurrenderAccepted Clone()
					{
						return null;
					}

					[Token(Token = "0x6007B44")]
					[Address(RVA = "0xC37FD0", Offset = "0xC373D0", VA = "0x180C37FD0", Slot = "0")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public override bool Equals(object other)
					{
						return default(bool);
					}

					[Token(Token = "0x6007B45")]
					[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public bool Equals(SurrenderAccepted other)
					{
						return default(bool);
					}

					[Token(Token = "0x6007B46")]
					[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override int GetHashCode()
					{
						return default(int);
					}

					[Token(Token = "0x6007B47")]
					[Address(RVA = "0xC38050", Offset = "0xC37450", VA = "0x180C38050", Slot = "3")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override string ToString()
					{
						return null;
					}

					[Token(Token = "0x6007B48")]
					[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void WriteTo(CodedOutputStream output)
					{
					}

					[Token(Token = "0x6007B49")]
					[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
					{
					}

					[Token(Token = "0x6007B4A")]
					[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public int CalculateSize()
					{
						return default(int);
					}

					[Token(Token = "0x6007B4B")]
					[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void MergeFrom(SurrenderAccepted other)
					{
					}

					[Token(Token = "0x6007B4C")]
					[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void MergeFrom(CodedInputStream input)
					{
					}

					[Token(Token = "0x6007B4D")]
					[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
					{
					}
				}

				[Token(Token = "0x2000BB9")]
				[DebuggerDisplay("{ToString(),nq}")]
				public sealed class SurrenderRefused : IMessage<SurrenderRefused>, IMessage, IEquatable<SurrenderRefused>, IDeepCloneable<SurrenderRefused>, IBufferMessage
				{
					[Token(Token = "0x4002BBA")]
					[FieldOffset(Offset = "0x0")]
					private static readonly MessageParser<SurrenderRefused> _parser;

					[Token(Token = "0x4002BBB")]
					[FieldOffset(Offset = "0x10")]
					private UnknownFieldSet _unknownFields;

					[Token(Token = "0x17001B27")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public static MessageParser<SurrenderRefused> Parser
					{
						[Token(Token = "0x6007B52")]
						[Address(RVA = "0xC39E10", Offset = "0xC39210", VA = "0x180C39E10")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x17001B28")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public static MessageDescriptor Descriptor
					{
						[Token(Token = "0x6007B53")]
						[Address(RVA = "0xC39D90", Offset = "0xC39190", VA = "0x180C39D90")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x17001B29")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
					{
						[Token(Token = "0x6007B54")]
						[Address(RVA = "0xC39E60", Offset = "0xC39260", VA = "0x180C39E60", Slot = "8")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x6007B55")]
					[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public SurrenderRefused()
					{
					}

					[Token(Token = "0x6007B56")]
					[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public SurrenderRefused(SurrenderRefused other)
					{
					}

					[Token(Token = "0x6007B57")]
					[Address(RVA = "0xC39B30", Offset = "0xC38F30", VA = "0x180C39B30", Slot = "10")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public SurrenderRefused Clone()
					{
						return null;
					}

					[Token(Token = "0x6007B58")]
					[Address(RVA = "0xC39BB0", Offset = "0xC38FB0", VA = "0x180C39BB0", Slot = "0")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override bool Equals(object other)
					{
						return default(bool);
					}

					[Token(Token = "0x6007B59")]
					[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public bool Equals(SurrenderRefused other)
					{
						return default(bool);
					}

					[Token(Token = "0x6007B5A")]
					[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override int GetHashCode()
					{
						return default(int);
					}

					[Token(Token = "0x6007B5B")]
					[Address(RVA = "0xC39C30", Offset = "0xC39030", VA = "0x180C39C30", Slot = "3")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override string ToString()
					{
						return null;
					}

					[Token(Token = "0x6007B5C")]
					[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void WriteTo(CodedOutputStream output)
					{
					}

					[Token(Token = "0x6007B5D")]
					[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
					{
					}

					[Token(Token = "0x6007B5E")]
					[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public int CalculateSize()
					{
						return default(int);
					}

					[Token(Token = "0x6007B5F")]
					[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public void MergeFrom(SurrenderRefused other)
					{
					}

					[Token(Token = "0x6007B60")]
					[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void MergeFrom(CodedInputStream input)
					{
					}

					[Token(Token = "0x6007B61")]
					[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
					{
					}
				}

				[Token(Token = "0x2000BBB")]
				[DebuggerDisplay("{ToString(),nq}")]
				public sealed class SurrenderBeforeTurn : IMessage<SurrenderBeforeTurn>, IMessage, IEquatable<SurrenderBeforeTurn>, IDeepCloneable<SurrenderBeforeTurn>, IBufferMessage
				{
					[Token(Token = "0x4002BBD")]
					[FieldOffset(Offset = "0x0")]
					private static readonly MessageParser<SurrenderBeforeTurn> _parser;

					[Token(Token = "0x4002BBE")]
					[FieldOffset(Offset = "0x10")]
					private UnknownFieldSet _unknownFields;

					[Token(Token = "0x4002BBF")]
					public const int MinTurnForSurrenderFieldNumber = 1;

					[Token(Token = "0x4002BC0")]
					[FieldOffset(Offset = "0x18")]
					private int minTurnForSurrender_;

					[Token(Token = "0x17001B2A")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public static MessageParser<SurrenderBeforeTurn> Parser
					{
						[Token(Token = "0x6007B66")]
						[Address(RVA = "0xC386B0", Offset = "0xC37AB0", VA = "0x180C386B0")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x17001B2B")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public static MessageDescriptor Descriptor
					{
						[Token(Token = "0x6007B67")]
						[Address(RVA = "0xC38630", Offset = "0xC37A30", VA = "0x180C38630")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x17001B2C")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
					{
						[Token(Token = "0x6007B68")]
						[Address(RVA = "0xC38700", Offset = "0xC37B00", VA = "0x180C38700", Slot = "8")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x17001B2D")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public int MinTurnForSurrender
					{
						[Token(Token = "0x6007B6C")]
						[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
						get
						{
							return default(int);
						}
						[Token(Token = "0x6007B6D")]
						[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
						set
						{
						}
					}

					[Token(Token = "0x6007B69")]
					[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public SurrenderBeforeTurn()
					{
					}

					[Token(Token = "0x6007B6A")]
					[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public SurrenderBeforeTurn(SurrenderBeforeTurn other)
					{
					}

					[Token(Token = "0x6007B6B")]
					[Address(RVA = "0xC383C0", Offset = "0xC377C0", VA = "0x180C383C0", Slot = "10")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public SurrenderBeforeTurn Clone()
					{
						return null;
					}

					[Token(Token = "0x6007B6E")]
					[Address(RVA = "0xC38440", Offset = "0xC37840", VA = "0x180C38440", Slot = "0")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override bool Equals(object other)
					{
						return default(bool);
					}

					[Token(Token = "0x6007B6F")]
					[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public bool Equals(SurrenderBeforeTurn other)
					{
						return default(bool);
					}

					[Token(Token = "0x6007B70")]
					[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public override int GetHashCode()
					{
						return default(int);
					}

					[Token(Token = "0x6007B71")]
					[Address(RVA = "0xC384D0", Offset = "0xC378D0", VA = "0x180C384D0", Slot = "3")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public override string ToString()
					{
						return null;
					}

					[Token(Token = "0x6007B72")]
					[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public void WriteTo(CodedOutputStream output)
					{
					}

					[Token(Token = "0x6007B73")]
					[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
					{
					}

					[Token(Token = "0x6007B74")]
					[Address(RVA = "0xC38330", Offset = "0xC37730", VA = "0x180C38330", Slot = "7")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public int CalculateSize()
					{
						return default(int);
					}

					[Token(Token = "0x6007B75")]
					[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void MergeFrom(SurrenderBeforeTurn other)
					{
					}

					[Token(Token = "0x6007B76")]
					[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void MergeFrom(CodedInputStream input)
					{
					}

					[Token(Token = "0x6007B77")]
					[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
					{
					}
				}

				[Token(Token = "0x2000BBD")]
				[DebuggerDisplay("{ToString(),nq}")]
				public sealed class SurrenderBeforeVote : IMessage<SurrenderBeforeVote>, IMessage, IEquatable<SurrenderBeforeVote>, IDeepCloneable<SurrenderBeforeVote>, IBufferMessage
				{
					[Token(Token = "0x4002BC2")]
					[FieldOffset(Offset = "0x0")]
					private static readonly MessageParser<SurrenderBeforeVote> _parser;

					[Token(Token = "0x4002BC3")]
					[FieldOffset(Offset = "0x10")]
					private UnknownFieldSet _unknownFields;

					[Token(Token = "0x17001B2E")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public static MessageParser<SurrenderBeforeVote> Parser
					{
						[Token(Token = "0x6007B7C")]
						[Address(RVA = "0xC38A90", Offset = "0xC37E90", VA = "0x180C38A90")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x17001B2F")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public static MessageDescriptor Descriptor
					{
						[Token(Token = "0x6007B7D")]
						[Address(RVA = "0xC38A10", Offset = "0xC37E10", VA = "0x180C38A10")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x17001B30")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
					{
						[Token(Token = "0x6007B7E")]
						[Address(RVA = "0xC38AE0", Offset = "0xC37EE0", VA = "0x180C38AE0", Slot = "8")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x6007B7F")]
					[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public SurrenderBeforeVote()
					{
					}

					[Token(Token = "0x6007B80")]
					[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public SurrenderBeforeVote(SurrenderBeforeVote other)
					{
					}

					[Token(Token = "0x6007B81")]
					[Address(RVA = "0xC387B0", Offset = "0xC37BB0", VA = "0x180C387B0", Slot = "10")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public SurrenderBeforeVote Clone()
					{
						return null;
					}

					[Token(Token = "0x6007B82")]
					[Address(RVA = "0xC38830", Offset = "0xC37C30", VA = "0x180C38830", Slot = "0")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override bool Equals(object other)
					{
						return default(bool);
					}

					[Token(Token = "0x6007B83")]
					[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public bool Equals(SurrenderBeforeVote other)
					{
						return default(bool);
					}

					[Token(Token = "0x6007B84")]
					[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override int GetHashCode()
					{
						return default(int);
					}

					[Token(Token = "0x6007B85")]
					[Address(RVA = "0xC388B0", Offset = "0xC37CB0", VA = "0x180C388B0", Slot = "3")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override string ToString()
					{
						return null;
					}

					[Token(Token = "0x6007B86")]
					[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void WriteTo(CodedOutputStream output)
					{
					}

					[Token(Token = "0x6007B87")]
					[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
					{
					}

					[Token(Token = "0x6007B88")]
					[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public int CalculateSize()
					{
						return default(int);
					}

					[Token(Token = "0x6007B89")]
					[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public void MergeFrom(SurrenderBeforeVote other)
					{
					}

					[Token(Token = "0x6007B8A")]
					[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public void MergeFrom(CodedInputStream input)
					{
					}

					[Token(Token = "0x6007B8B")]
					[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
					{
					}
				}
			}

			[Token(Token = "0x4002BA9")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<SurrenderResponse> _parser;

			[Token(Token = "0x4002BAA")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x4002BAB")]
			public const int AcceptedFieldNumber = 1;

			[Token(Token = "0x4002BAC")]
			public const int RefusedFieldNumber = 2;

			[Token(Token = "0x4002BAD")]
			public const int BeforeTurnFieldNumber = 3;

			[Token(Token = "0x4002BAE")]
			public const int BeforeVoteFieldNumber = 4;

			[Token(Token = "0x4002BAF")]
			[FieldOffset(Offset = "0x18")]
			private object response_;

			[Token(Token = "0x4002BB0")]
			[FieldOffset(Offset = "0x20")]
			private ResponseOneofCase responseCase_;

			[Token(Token = "0x17001B1C")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageParser<SurrenderResponse> Parser
			{
				[Token(Token = "0x6007B23")]
				[Address(RVA = "0xC3ADA0", Offset = "0xC3A1A0", VA = "0x180C3ADA0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001B1D")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6007B24")]
				[Address(RVA = "0xC3AD20", Offset = "0xC3A120", VA = "0x180C3AD20")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001B1E")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6007B25")]
				[Address(RVA = "0xC3B360", Offset = "0xC3A760", VA = "0x180C3B360", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001B1F")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Types.SurrenderAccepted Accepted
			{
				[Token(Token = "0x6007B29")]
				[Address(RVA = "0xC3AC00", Offset = "0xC3A000", VA = "0x180C3AC00")]
				get
				{
					return null;
				}
				[Token(Token = "0x6007B2A")]
				[Address(RVA = "0x917DA0", Offset = "0x9171A0", VA = "0x180917DA0")]
				set
				{
				}
			}

			[Token(Token = "0x17001B20")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Types.SurrenderRefused Refused
			{
				[Token(Token = "0x6007B2B")]
				[Address(RVA = "0xC3ADF0", Offset = "0xC3A1F0", VA = "0x180C3ADF0")]
				get
				{
					return null;
				}
				[Token(Token = "0x6007B2C")]
				[Address(RVA = "0x917DE0", Offset = "0x9171E0", VA = "0x180917DE0")]
				set
				{
				}
			}

			[Token(Token = "0x17001B21")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public Types.SurrenderBeforeTurn BeforeTurn
			{
				[Token(Token = "0x6007B2D")]
				[Address(RVA = "0xC3AC60", Offset = "0xC3A060", VA = "0x180C3AC60")]
				get
				{
					return null;
				}
				[Token(Token = "0x6007B2E")]
				[Address(RVA = "0x919620", Offset = "0x918A20", VA = "0x180919620")]
				set
				{
				}
			}

			[Token(Token = "0x17001B22")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Types.SurrenderBeforeVote BeforeVote
			{
				[Token(Token = "0x6007B2F")]
				[Address(RVA = "0xC3ACC0", Offset = "0xC3A0C0", VA = "0x180C3ACC0")]
				get
				{
					return null;
				}
				[Token(Token = "0x6007B30")]
				[Address(RVA = "0x94E860", Offset = "0x94DC60", VA = "0x18094E860")]
				set
				{
				}
			}

			[Token(Token = "0x17001B23")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public ResponseOneofCase ResponseCase
			{
				[Token(Token = "0x6007B31")]
				[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
				get
				{
					return default(ResponseOneofCase);
				}
			}

			[Token(Token = "0x6007B26")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public SurrenderResponse()
			{
			}

			[Token(Token = "0x6007B27")]
			[Address(RVA = "0xC3A970", Offset = "0xC39D70", VA = "0x180C3A970")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public SurrenderResponse(SurrenderResponse other)
			{
			}

			[Token(Token = "0x6007B28")]
			[Address(RVA = "0xC3A130", Offset = "0xC39530", VA = "0x180C3A130", Slot = "10")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public SurrenderResponse Clone()
			{
				return null;
			}

			[Token(Token = "0x6007B32")]
			[Address(RVA = "0x916DD0", Offset = "0x9161D0", VA = "0x180916DD0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void ClearResponse()
			{
			}

			[Token(Token = "0x6007B33")]
			[Address(RVA = "0xC3A320", Offset = "0xC39720", VA = "0x180C3A320", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6007B34")]
			[Address(RVA = "0xC3A190", Offset = "0xC39590", VA = "0x180C3A190", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(SurrenderResponse other)
			{
				return default(bool);
			}

			[Token(Token = "0x6007B35")]
			[Address(RVA = "0xC3A380", Offset = "0xC39780", VA = "0x180C3A380", Slot = "2")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6007B36")]
			[Address(RVA = "0xC3A810", Offset = "0xC39C10", VA = "0x180C3A810", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6007B37")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6007B38")]
			[Address(RVA = "0xC3B180", Offset = "0xC3A580", VA = "0x180C3B180", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6007B39")]
			[Address(RVA = "0xC39F10", Offset = "0xC39310", VA = "0x180C39F10", Slot = "7")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6007B3A")]
			[Address(RVA = "0xC3A590", Offset = "0xC39990", VA = "0x180C3A590", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(SurrenderResponse other)
			{
			}

			[Token(Token = "0x6007B3B")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6007B3C")]
			[Address(RVA = "0xC3AE50", Offset = "0xC3A250", VA = "0x180C3AE50", Slot = "11")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}

		[Token(Token = "0x2000BC0")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class SurrenderVoteResponse : IMessage<SurrenderVoteResponse>, IMessage, IEquatable<SurrenderVoteResponse>, IDeepCloneable<SurrenderVoteResponse>, IBufferMessage
		{
			[Token(Token = "0x2000BC1")]
			public enum ResponseOneofCase
			{
				[Token(Token = "0x4002BD0")]
				None,
				[Token(Token = "0x4002BD1")]
				Accepted,
				[Token(Token = "0x4002BD2")]
				Refused,
				[Token(Token = "0x4002BD3")]
				BeforeTurn,
				[Token(Token = "0x4002BD4")]
				AlreadyAsked,
				[Token(Token = "0x4002BD5")]
				Waiting
			}

			[Token(Token = "0x2000BC2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static class Types
			{
				[Token(Token = "0x2000BC3")]
				[DebuggerDisplay("{ToString(),nq}")]
				public sealed class SurrenderVoteAccepted : IMessage<SurrenderVoteAccepted>, IMessage, IEquatable<SurrenderVoteAccepted>, IDeepCloneable<SurrenderVoteAccepted>, IBufferMessage
				{
					[Token(Token = "0x4002BD6")]
					[FieldOffset(Offset = "0x0")]
					private static readonly MessageParser<SurrenderVoteAccepted> _parser;

					[Token(Token = "0x4002BD7")]
					[FieldOffset(Offset = "0x10")]
					private UnknownFieldSet _unknownFields;

					[Token(Token = "0x17001B3A")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public static MessageParser<SurrenderVoteAccepted> Parser
					{
						[Token(Token = "0x6007BB0")]
						[Address(RVA = "0xC3BBC0", Offset = "0xC3AFC0", VA = "0x180C3BBC0")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x17001B3B")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public static MessageDescriptor Descriptor
					{
						[Token(Token = "0x6007BB1")]
						[Address(RVA = "0xC3BB40", Offset = "0xC3AF40", VA = "0x180C3BB40")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x17001B3C")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
					{
						[Token(Token = "0x6007BB2")]
						[Address(RVA = "0xC3BC10", Offset = "0xC3B010", VA = "0x180C3BC10", Slot = "8")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x6007BB3")]
					[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public SurrenderVoteAccepted()
					{
					}

					[Token(Token = "0x6007BB4")]
					[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public SurrenderVoteAccepted(SurrenderVoteAccepted other)
					{
					}

					[Token(Token = "0x6007BB5")]
					[Address(RVA = "0xC3B8E0", Offset = "0xC3ACE0", VA = "0x180C3B8E0", Slot = "10")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public SurrenderVoteAccepted Clone()
					{
						return null;
					}

					[Token(Token = "0x6007BB6")]
					[Address(RVA = "0xC3B960", Offset = "0xC3AD60", VA = "0x180C3B960", Slot = "0")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override bool Equals(object other)
					{
						return default(bool);
					}

					[Token(Token = "0x6007BB7")]
					[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public bool Equals(SurrenderVoteAccepted other)
					{
						return default(bool);
					}

					[Token(Token = "0x6007BB8")]
					[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override int GetHashCode()
					{
						return default(int);
					}

					[Token(Token = "0x6007BB9")]
					[Address(RVA = "0xC3B9E0", Offset = "0xC3ADE0", VA = "0x180C3B9E0", Slot = "3")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public override string ToString()
					{
						return null;
					}

					[Token(Token = "0x6007BBA")]
					[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void WriteTo(CodedOutputStream output)
					{
					}

					[Token(Token = "0x6007BBB")]
					[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
					{
					}

					[Token(Token = "0x6007BBC")]
					[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public int CalculateSize()
					{
						return default(int);
					}

					[Token(Token = "0x6007BBD")]
					[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void MergeFrom(SurrenderVoteAccepted other)
					{
					}

					[Token(Token = "0x6007BBE")]
					[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void MergeFrom(CodedInputStream input)
					{
					}

					[Token(Token = "0x6007BBF")]
					[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
					{
					}
				}

				[Token(Token = "0x2000BC5")]
				[DebuggerDisplay("{ToString(),nq}")]
				public sealed class SurrenderVoteRefused : IMessage<SurrenderVoteRefused>, IMessage, IEquatable<SurrenderVoteRefused>, IDeepCloneable<SurrenderVoteRefused>, IBufferMessage
				{
					[Token(Token = "0x4002BD9")]
					[FieldOffset(Offset = "0x0")]
					private static readonly MessageParser<SurrenderVoteRefused> _parser;

					[Token(Token = "0x4002BDA")]
					[FieldOffset(Offset = "0x10")]
					private UnknownFieldSet _unknownFields;

					[Token(Token = "0x17001B3D")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public static MessageParser<SurrenderVoteRefused> Parser
					{
						[Token(Token = "0x6007BC4")]
						[Address(RVA = "0xC3D1E0", Offset = "0xC3C5E0", VA = "0x180C3D1E0")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x17001B3E")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public static MessageDescriptor Descriptor
					{
						[Token(Token = "0x6007BC5")]
						[Address(RVA = "0xC3D160", Offset = "0xC3C560", VA = "0x180C3D160")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x17001B3F")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
					{
						[Token(Token = "0x6007BC6")]
						[Address(RVA = "0xC3D230", Offset = "0xC3C630", VA = "0x180C3D230", Slot = "8")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x6007BC7")]
					[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public SurrenderVoteRefused()
					{
					}

					[Token(Token = "0x6007BC8")]
					[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public SurrenderVoteRefused(SurrenderVoteRefused other)
					{
					}

					[Token(Token = "0x6007BC9")]
					[Address(RVA = "0xC3CF00", Offset = "0xC3C300", VA = "0x180C3CF00", Slot = "10")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public SurrenderVoteRefused Clone()
					{
						return null;
					}

					[Token(Token = "0x6007BCA")]
					[Address(RVA = "0xC3CF80", Offset = "0xC3C380", VA = "0x180C3CF80", Slot = "0")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override bool Equals(object other)
					{
						return default(bool);
					}

					[Token(Token = "0x6007BCB")]
					[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public bool Equals(SurrenderVoteRefused other)
					{
						return default(bool);
					}

					[Token(Token = "0x6007BCC")]
					[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override int GetHashCode()
					{
						return default(int);
					}

					[Token(Token = "0x6007BCD")]
					[Address(RVA = "0xC3D000", Offset = "0xC3C400", VA = "0x180C3D000", Slot = "3")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override string ToString()
					{
						return null;
					}

					[Token(Token = "0x6007BCE")]
					[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void WriteTo(CodedOutputStream output)
					{
					}

					[Token(Token = "0x6007BCF")]
					[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
					{
					}

					[Token(Token = "0x6007BD0")]
					[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public int CalculateSize()
					{
						return default(int);
					}

					[Token(Token = "0x6007BD1")]
					[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public void MergeFrom(SurrenderVoteRefused other)
					{
					}

					[Token(Token = "0x6007BD2")]
					[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void MergeFrom(CodedInputStream input)
					{
					}

					[Token(Token = "0x6007BD3")]
					[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
					{
					}
				}

				[Token(Token = "0x2000BC7")]
				[DebuggerDisplay("{ToString(),nq}")]
				public sealed class SurrenderVoteBeforeTurn : IMessage<SurrenderVoteBeforeTurn>, IMessage, IEquatable<SurrenderVoteBeforeTurn>, IDeepCloneable<SurrenderVoteBeforeTurn>, IBufferMessage
				{
					[Token(Token = "0x4002BDC")]
					[FieldOffset(Offset = "0x0")]
					private static readonly MessageParser<SurrenderVoteBeforeTurn> _parser;

					[Token(Token = "0x4002BDD")]
					[FieldOffset(Offset = "0x10")]
					private UnknownFieldSet _unknownFields;

					[Token(Token = "0x4002BDE")]
					public const int MinTurnForSurrenderVoteFieldNumber = 1;

					[Token(Token = "0x4002BDF")]
					[FieldOffset(Offset = "0x18")]
					private int minTurnForSurrenderVote_;

					[Token(Token = "0x17001B40")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public static MessageParser<SurrenderVoteBeforeTurn> Parser
					{
						[Token(Token = "0x6007BD8")]
						[Address(RVA = "0xC3C420", Offset = "0xC3B820", VA = "0x180C3C420")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x17001B41")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public static MessageDescriptor Descriptor
					{
						[Token(Token = "0x6007BD9")]
						[Address(RVA = "0xC3C3A0", Offset = "0xC3B7A0", VA = "0x180C3C3A0")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x17001B42")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
					{
						[Token(Token = "0x6007BDA")]
						[Address(RVA = "0xC3C470", Offset = "0xC3B870", VA = "0x180C3C470", Slot = "8")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x17001B43")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public int MinTurnForSurrenderVote
					{
						[Token(Token = "0x6007BDE")]
						[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
						get
						{
							return default(int);
						}
						[Token(Token = "0x6007BDF")]
						[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
						set
						{
						}
					}

					[Token(Token = "0x6007BDB")]
					[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public SurrenderVoteBeforeTurn()
					{
					}

					[Token(Token = "0x6007BDC")]
					[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public SurrenderVoteBeforeTurn(SurrenderVoteBeforeTurn other)
					{
					}

					[Token(Token = "0x6007BDD")]
					[Address(RVA = "0xC3C130", Offset = "0xC3B530", VA = "0x180C3C130", Slot = "10")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public SurrenderVoteBeforeTurn Clone()
					{
						return null;
					}

					[Token(Token = "0x6007BE0")]
					[Address(RVA = "0xC3C1B0", Offset = "0xC3B5B0", VA = "0x180C3C1B0", Slot = "0")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override bool Equals(object other)
					{
						return default(bool);
					}

					[Token(Token = "0x6007BE1")]
					[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public bool Equals(SurrenderVoteBeforeTurn other)
					{
						return default(bool);
					}

					[Token(Token = "0x6007BE2")]
					[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override int GetHashCode()
					{
						return default(int);
					}

					[Token(Token = "0x6007BE3")]
					[Address(RVA = "0xC3C240", Offset = "0xC3B640", VA = "0x180C3C240", Slot = "3")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public override string ToString()
					{
						return null;
					}

					[Token(Token = "0x6007BE4")]
					[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public void WriteTo(CodedOutputStream output)
					{
					}

					[Token(Token = "0x6007BE5")]
					[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
					{
					}

					[Token(Token = "0x6007BE6")]
					[Address(RVA = "0xC3C0A0", Offset = "0xC3B4A0", VA = "0x180C3C0A0", Slot = "7")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public int CalculateSize()
					{
						return default(int);
					}

					[Token(Token = "0x6007BE7")]
					[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void MergeFrom(SurrenderVoteBeforeTurn other)
					{
					}

					[Token(Token = "0x6007BE8")]
					[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void MergeFrom(CodedInputStream input)
					{
					}

					[Token(Token = "0x6007BE9")]
					[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
					{
					}
				}

				[Token(Token = "0x2000BC9")]
				[DebuggerDisplay("{ToString(),nq}")]
				public sealed class SurrenderVoteAlreadyAsked : IMessage<SurrenderVoteAlreadyAsked>, IMessage, IEquatable<SurrenderVoteAlreadyAsked>, IDeepCloneable<SurrenderVoteAlreadyAsked>, IBufferMessage
				{
					[Token(Token = "0x4002BE1")]
					[FieldOffset(Offset = "0x0")]
					private static readonly MessageParser<SurrenderVoteAlreadyAsked> _parser;

					[Token(Token = "0x4002BE2")]
					[FieldOffset(Offset = "0x10")]
					private UnknownFieldSet _unknownFields;

					[Token(Token = "0x17001B44")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public static MessageParser<SurrenderVoteAlreadyAsked> Parser
					{
						[Token(Token = "0x6007BEE")]
						[Address(RVA = "0xC3BFA0", Offset = "0xC3B3A0", VA = "0x180C3BFA0")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x17001B45")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public static MessageDescriptor Descriptor
					{
						[Token(Token = "0x6007BEF")]
						[Address(RVA = "0xC3BF20", Offset = "0xC3B320", VA = "0x180C3BF20")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x17001B46")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
					{
						[Token(Token = "0x6007BF0")]
						[Address(RVA = "0xC3BFF0", Offset = "0xC3B3F0", VA = "0x180C3BFF0", Slot = "8")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x6007BF1")]
					[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public SurrenderVoteAlreadyAsked()
					{
					}

					[Token(Token = "0x6007BF2")]
					[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public SurrenderVoteAlreadyAsked(SurrenderVoteAlreadyAsked other)
					{
					}

					[Token(Token = "0x6007BF3")]
					[Address(RVA = "0xC3BCC0", Offset = "0xC3B0C0", VA = "0x180C3BCC0", Slot = "10")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public SurrenderVoteAlreadyAsked Clone()
					{
						return null;
					}

					[Token(Token = "0x6007BF4")]
					[Address(RVA = "0xC3BD40", Offset = "0xC3B140", VA = "0x180C3BD40", Slot = "0")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public override bool Equals(object other)
					{
						return default(bool);
					}

					[Token(Token = "0x6007BF5")]
					[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public bool Equals(SurrenderVoteAlreadyAsked other)
					{
						return default(bool);
					}

					[Token(Token = "0x6007BF6")]
					[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override int GetHashCode()
					{
						return default(int);
					}

					[Token(Token = "0x6007BF7")]
					[Address(RVA = "0xC3BDC0", Offset = "0xC3B1C0", VA = "0x180C3BDC0", Slot = "3")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override string ToString()
					{
						return null;
					}

					[Token(Token = "0x6007BF8")]
					[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public void WriteTo(CodedOutputStream output)
					{
					}

					[Token(Token = "0x6007BF9")]
					[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
					{
					}

					[Token(Token = "0x6007BFA")]
					[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public int CalculateSize()
					{
						return default(int);
					}

					[Token(Token = "0x6007BFB")]
					[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void MergeFrom(SurrenderVoteAlreadyAsked other)
					{
					}

					[Token(Token = "0x6007BFC")]
					[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void MergeFrom(CodedInputStream input)
					{
					}

					[Token(Token = "0x6007BFD")]
					[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
					{
					}
				}

				[Token(Token = "0x2000BCB")]
				[DebuggerDisplay("{ToString(),nq}")]
				public sealed class SurrenderVoteWaiting : IMessage<SurrenderVoteWaiting>, IMessage, IEquatable<SurrenderVoteWaiting>, IDeepCloneable<SurrenderVoteWaiting>, IBufferMessage
				{
					[Token(Token = "0x4002BE4")]
					[FieldOffset(Offset = "0x0")]
					private static readonly MessageParser<SurrenderVoteWaiting> _parser;

					[Token(Token = "0x4002BE5")]
					[FieldOffset(Offset = "0x10")]
					private UnknownFieldSet _unknownFields;

					[Token(Token = "0x4002BE6")]
					public const int VoteUnlockTimeStampFieldNumber = 1;

					[Token(Token = "0x4002BE7")]
					[FieldOffset(Offset = "0x18")]
					private string voteUnlockTimeStamp_;

					[Token(Token = "0x17001B47")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public static MessageParser<SurrenderVoteWaiting> Parser
					{
						[Token(Token = "0x6007C02")]
						[Address(RVA = "0xC3FE40", Offset = "0xC3F240", VA = "0x180C3FE40")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x17001B48")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public static MessageDescriptor Descriptor
					{
						[Token(Token = "0x6007C03")]
						[Address(RVA = "0xC3FDC0", Offset = "0xC3F1C0", VA = "0x180C3FDC0")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x17001B49")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
					{
						[Token(Token = "0x6007C04")]
						[Address(RVA = "0xC3FF50", Offset = "0xC3F350", VA = "0x180C3FF50", Slot = "8")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x17001B4A")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public string VoteUnlockTimeStamp
					{
						[Token(Token = "0x6007C08")]
						[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
						get
						{
							return null;
						}
						[Token(Token = "0x6007C09")]
						[Address(RVA = "0xC40000", Offset = "0xC3F400", VA = "0x180C40000")]
						set
						{
						}
					}

					[Token(Token = "0x6007C05")]
					[Address(RVA = "0xC3FCD0", Offset = "0xC3F0D0", VA = "0x180C3FCD0")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public SurrenderVoteWaiting()
					{
					}

					[Token(Token = "0x6007C06")]
					[Address(RVA = "0xC3FD20", Offset = "0xC3F120", VA = "0x180C3FD20")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public SurrenderVoteWaiting(SurrenderVoteWaiting other)
					{
					}

					[Token(Token = "0x6007C07")]
					[Address(RVA = "0xC3F990", Offset = "0xC3ED90", VA = "0x180C3F990", Slot = "10")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public SurrenderVoteWaiting Clone()
					{
						return null;
					}

					[Token(Token = "0x6007C0A")]
					[Address(RVA = "0xC3FA60", Offset = "0xC3EE60", VA = "0x180C3FA60", Slot = "0")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override bool Equals(object other)
					{
						return default(bool);
					}

					[Token(Token = "0x6007C0B")]
					[Address(RVA = "0x91CE00", Offset = "0x91C200", VA = "0x18091CE00", Slot = "9")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public bool Equals(SurrenderVoteWaiting other)
					{
						return default(bool);
					}

					[Token(Token = "0x6007C0C")]
					[Address(RVA = "0x91CF20", Offset = "0x91C320", VA = "0x18091CF20", Slot = "2")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override int GetHashCode()
					{
						return default(int);
					}

					[Token(Token = "0x6007C0D")]
					[Address(RVA = "0xC3FB70", Offset = "0xC3EF70", VA = "0x180C3FB70", Slot = "3")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override string ToString()
					{
						return null;
					}

					[Token(Token = "0x6007C0E")]
					[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public void WriteTo(CodedOutputStream output)
					{
					}

					[Token(Token = "0x6007C0F")]
					[Address(RVA = "0x91D400", Offset = "0x91C800", VA = "0x18091D400", Slot = "12")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
					{
					}

					[Token(Token = "0x6007C10")]
					[Address(RVA = "0xC3F900", Offset = "0xC3ED00", VA = "0x180C3F900", Slot = "7")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public int CalculateSize()
					{
						return default(int);
					}

					[Token(Token = "0x6007C11")]
					[Address(RVA = "0xC3FB10", Offset = "0xC3EF10", VA = "0x180C3FB10", Slot = "4")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void MergeFrom(SurrenderVoteWaiting other)
					{
					}

					[Token(Token = "0x6007C12")]
					[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void MergeFrom(CodedInputStream input)
					{
					}

					[Token(Token = "0x6007C13")]
					[Address(RVA = "0xC3FE90", Offset = "0xC3F290", VA = "0x180C3FE90", Slot = "11")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
					{
					}
				}
			}

			[Token(Token = "0x4002BC6")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<SurrenderVoteResponse> _parser;

			[Token(Token = "0x4002BC7")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x4002BC8")]
			public const int AcceptedFieldNumber = 1;

			[Token(Token = "0x4002BC9")]
			public const int RefusedFieldNumber = 2;

			[Token(Token = "0x4002BCA")]
			public const int BeforeTurnFieldNumber = 3;

			[Token(Token = "0x4002BCB")]
			public const int AlreadyAskedFieldNumber = 4;

			[Token(Token = "0x4002BCC")]
			public const int WaitingFieldNumber = 5;

			[Token(Token = "0x4002BCD")]
			[FieldOffset(Offset = "0x18")]
			private object response_;

			[Token(Token = "0x4002BCE")]
			[FieldOffset(Offset = "0x20")]
			private ResponseOneofCase responseCase_;

			[Token(Token = "0x17001B31")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<SurrenderVoteResponse> Parser
			{
				[Token(Token = "0x6007B93")]
				[Address(RVA = "0xC3E410", Offset = "0xC3D810", VA = "0x180C3E410")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001B32")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6007B94")]
				[Address(RVA = "0xC3E390", Offset = "0xC3D790", VA = "0x180C3E390")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001B33")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6007B95")]
				[Address(RVA = "0xC3EB50", Offset = "0xC3DF50", VA = "0x180C3EB50", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001B34")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Types.SurrenderVoteAccepted Accepted
			{
				[Token(Token = "0x6007B99")]
				[Address(RVA = "0xC3E270", Offset = "0xC3D670", VA = "0x180C3E270")]
				get
				{
					return null;
				}
				[Token(Token = "0x6007B9A")]
				[Address(RVA = "0x917DA0", Offset = "0x9171A0", VA = "0x180917DA0")]
				set
				{
				}
			}

			[Token(Token = "0x17001B35")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Types.SurrenderVoteRefused Refused
			{
				[Token(Token = "0x6007B9B")]
				[Address(RVA = "0xC3E460", Offset = "0xC3D860", VA = "0x180C3E460")]
				get
				{
					return null;
				}
				[Token(Token = "0x6007B9C")]
				[Address(RVA = "0x917DE0", Offset = "0x9171E0", VA = "0x180917DE0")]
				set
				{
				}
			}

			[Token(Token = "0x17001B36")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Types.SurrenderVoteBeforeTurn BeforeTurn
			{
				[Token(Token = "0x6007B9D")]
				[Address(RVA = "0xC3E330", Offset = "0xC3D730", VA = "0x180C3E330")]
				get
				{
					return null;
				}
				[Token(Token = "0x6007B9E")]
				[Address(RVA = "0x919620", Offset = "0x918A20", VA = "0x180919620")]
				set
				{
				}
			}

			[Token(Token = "0x17001B37")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Types.SurrenderVoteAlreadyAsked AlreadyAsked
			{
				[Token(Token = "0x6007B9F")]
				[Address(RVA = "0xC3E2D0", Offset = "0xC3D6D0", VA = "0x180C3E2D0")]
				get
				{
					return null;
				}
				[Token(Token = "0x6007BA0")]
				[Address(RVA = "0x94E860", Offset = "0x94DC60", VA = "0x18094E860")]
				set
				{
				}
			}

			[Token(Token = "0x17001B38")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public Types.SurrenderVoteWaiting Waiting
			{
				[Token(Token = "0x6007BA1")]
				[Address(RVA = "0xC3E4C0", Offset = "0xC3D8C0", VA = "0x180C3E4C0")]
				get
				{
					return null;
				}
				[Token(Token = "0x6007BA2")]
				[Address(RVA = "0x94E820", Offset = "0x94DC20", VA = "0x18094E820")]
				set
				{
				}
			}

			[Token(Token = "0x17001B39")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public ResponseOneofCase ResponseCase
			{
				[Token(Token = "0x6007BA3")]
				[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
				get
				{
					return default(ResponseOneofCase);
				}
			}

			[Token(Token = "0x6007B96")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public SurrenderVoteResponse()
			{
			}

			[Token(Token = "0x6007B97")]
			[Address(RVA = "0xC3DF00", Offset = "0xC3D300", VA = "0x180C3DF00")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public SurrenderVoteResponse(SurrenderVoteResponse other)
			{
			}

			[Token(Token = "0x6007B98")]
			[Address(RVA = "0xC3D570", Offset = "0xC3C970", VA = "0x180C3D570", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public SurrenderVoteResponse Clone()
			{
				return null;
			}

			[Token(Token = "0x6007BA4")]
			[Address(RVA = "0x916DD0", Offset = "0x9161D0", VA = "0x180916DD0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void ClearResponse()
			{
			}

			[Token(Token = "0x6007BA5")]
			[Address(RVA = "0xC3D5D0", Offset = "0xC3C9D0", VA = "0x180C3D5D0", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6007BA6")]
			[Address(RVA = "0xC3D630", Offset = "0xC3CA30", VA = "0x180C3D630", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(SurrenderVoteResponse other)
			{
				return default(bool);
			}

			[Token(Token = "0x6007BA7")]
			[Address(RVA = "0xC3D7F0", Offset = "0xC3CBF0", VA = "0x180C3D7F0", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6007BA8")]
			[Address(RVA = "0xC3DDA0", Offset = "0xC3D1A0", VA = "0x180C3DDA0", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6007BA9")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6007BAA")]
			[Address(RVA = "0xC3E900", Offset = "0xC3DD00", VA = "0x180C3E900", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6007BAB")]
			[Address(RVA = "0xC3D2E0", Offset = "0xC3C6E0", VA = "0x180C3D2E0", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6007BAC")]
			[Address(RVA = "0xC3DA70", Offset = "0xC3CE70", VA = "0x180C3DA70", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(SurrenderVoteResponse other)
			{
			}

			[Token(Token = "0x6007BAD")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6007BAE")]
			[Address(RVA = "0xC3E520", Offset = "0xC3D920", VA = "0x180C3E520", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x4002BA1")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<SurrenderInfoResponse> _parser;

	[Token(Token = "0x4002BA2")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002BA3")]
	public const int SurrenderResponseFieldNumber = 1;

	[Token(Token = "0x4002BA4")]
	[FieldOffset(Offset = "0x18")]
	private Types.SurrenderResponse surrenderResponse_;

	[Token(Token = "0x4002BA5")]
	public const int SurrenderVoteResponseFieldNumber = 2;

	[Token(Token = "0x4002BA6")]
	[FieldOffset(Offset = "0x20")]
	private Types.SurrenderVoteResponse surrenderVoteResponse_;

	[Token(Token = "0x4002BA7")]
	public const int HasSanctionFieldNumber = 3;

	[Token(Token = "0x4002BA8")]
	[FieldOffset(Offset = "0x28")]
	private bool hasSanction_;

	[Token(Token = "0x17001B16")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SurrenderInfoResponse> Parser
	{
		[Token(Token = "0x6007B0C")]
		[Address(RVA = "0xC39890", Offset = "0xC38C90", VA = "0x180C39890")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B17")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007B0D")]
		[Address(RVA = "0xC397E0", Offset = "0xC38BE0", VA = "0x180C397E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B18")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007B0E")]
		[Address(RVA = "0xC39AF0", Offset = "0xC38EF0", VA = "0x180C39AF0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B19")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.SurrenderResponse SurrenderResponse
	{
		[Token(Token = "0x6007B12")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007B13")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x17001B1A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.SurrenderVoteResponse SurrenderVoteResponse
	{
		[Token(Token = "0x6007B14")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007B15")]
		[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
		set
		{
		}
	}

	[Token(Token = "0x17001B1B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasSanction
	{
		[Token(Token = "0x6007B16")]
		[Address(RVA = "0x8529D0", Offset = "0x851DD0", VA = "0x1808529D0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6007B17")]
		[Address(RVA = "0x9A1E80", Offset = "0x9A1280", VA = "0x1809A1E80")]
		set
		{
		}
	}

	[Token(Token = "0x6007B0F")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SurrenderInfoResponse()
	{
	}

	[Token(Token = "0x6007B10")]
	[Address(RVA = "0xC396B0", Offset = "0xC38AB0", VA = "0x180C396B0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SurrenderInfoResponse(SurrenderInfoResponse other)
	{
	}

	[Token(Token = "0x6007B11")]
	[Address(RVA = "0xC390A0", Offset = "0xC384A0", VA = "0x180C390A0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SurrenderInfoResponse Clone()
	{
		return null;
	}

	[Token(Token = "0x6007B18")]
	[Address(RVA = "0xC391F0", Offset = "0xC385F0", VA = "0x180C391F0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007B19")]
	[Address(RVA = "0xC392C0", Offset = "0xC386C0", VA = "0x180C392C0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SurrenderInfoResponse other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007B1A")]
	[Address(RVA = "0xC39340", Offset = "0xC38740", VA = "0x180C39340", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007B1B")]
	[Address(RVA = "0xC39550", Offset = "0xC38950", VA = "0x180C39550", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007B1C")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007B1D")]
	[Address(RVA = "0xC39A50", Offset = "0xC38E50", VA = "0x180C39A50", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007B1E")]
	[Address(RVA = "0xC38FD0", Offset = "0xC383D0", VA = "0x180C38FD0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007B1F")]
	[Address(RVA = "0xC39420", Offset = "0xC38820", VA = "0x180C39420", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(SurrenderInfoResponse other)
	{
	}

	[Token(Token = "0x6007B20")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007B21")]
	[Address(RVA = "0xC398E0", Offset = "0xC38CE0", VA = "0x180C398E0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
