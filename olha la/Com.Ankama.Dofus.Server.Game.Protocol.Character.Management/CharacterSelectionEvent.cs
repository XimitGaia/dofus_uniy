using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character.Management;

[Token(Token = "0x20008AB")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CharacterSelectionEvent : IMessage<CharacterSelectionEvent>, IMessage, IEquatable<CharacterSelectionEvent>, IDeepCloneable<CharacterSelectionEvent>, IBufferMessage
{
	[Token(Token = "0x20008AC")]
	public enum ResultOneofCase
	{
		[Token(Token = "0x4001DF2")]
		None,
		[Token(Token = "0x4001DF3")]
		Error,
		[Token(Token = "0x4001DF4")]
		Success
	}

	[Token(Token = "0x20008AD")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x20008AE")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class Error : IMessage<Error>, IMessage, IEquatable<Error>, IDeepCloneable<Error>, IBufferMessage
		{
			[Token(Token = "0x4001DF5")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<Error> _parser;

			[Token(Token = "0x4001DF6")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x17001386")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<Error> Parser
			{
				[Token(Token = "0x6005BE3")]
				[Address(RVA = "0xB26730", Offset = "0xB25B30", VA = "0x180B26730")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001387")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6005BE4")]
				[Address(RVA = "0xB266B0", Offset = "0xB25AB0", VA = "0x180B266B0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001388")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6005BE5")]
				[Address(RVA = "0xB26780", Offset = "0xB25B80", VA = "0x180B26780", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6005BE6")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public Error()
			{
			}

			[Token(Token = "0x6005BE7")]
			[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Error(Error other)
			{
			}

			[Token(Token = "0x6005BE8")]
			[Address(RVA = "0xB26450", Offset = "0xB25850", VA = "0x180B26450", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Error Clone()
			{
				return null;
			}

			[Token(Token = "0x6005BE9")]
			[Address(RVA = "0xB264D0", Offset = "0xB258D0", VA = "0x180B264D0", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6005BEA")]
			[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool Equals(Error other)
			{
				return default(bool);
			}

			[Token(Token = "0x6005BEB")]
			[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6005BEC")]
			[Address(RVA = "0xB26550", Offset = "0xB25950", VA = "0x180B26550", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6005BED")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6005BEE")]
			[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6005BEF")]
			[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6005BF0")]
			[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(Error other)
			{
			}

			[Token(Token = "0x6005BF1")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6005BF2")]
			[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}

		[Token(Token = "0x20008B0")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class Success : IMessage<Success>, IMessage, IEquatable<Success>, IDeepCloneable<Success>, IBufferMessage
		{
			[Token(Token = "0x4001DF8")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<Success> _parser;

			[Token(Token = "0x4001DF9")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x4001DFA")]
			public const int CharacterFieldNumber = 1;

			[Token(Token = "0x4001DFB")]
			[FieldOffset(Offset = "0x18")]
			private Com.Ankama.Dofus.Server.Game.Protocol.Common.Character character_;

			[Token(Token = "0x4001DFC")]
			public const int CollectStatsFieldNumber = 2;

			[Token(Token = "0x4001DFD")]
			[FieldOffset(Offset = "0x20")]
			private bool collectStats_;

			[Token(Token = "0x17001389")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageParser<Success> Parser
			{
				[Token(Token = "0x6005BF7")]
				[Address(RVA = "0xB29800", Offset = "0xB28C00", VA = "0x180B29800")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700138A")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6005BF8")]
				[Address(RVA = "0xB29780", Offset = "0xB28B80", VA = "0x180B29780")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700138B")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6005BF9")]
				[Address(RVA = "0xB29980", Offset = "0xB28D80", VA = "0x180B29980", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700138C")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public Com.Ankama.Dofus.Server.Game.Protocol.Common.Character Character
			{
				[Token(Token = "0x6005BFD")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return null;
				}
				[Token(Token = "0x6005BFE")]
				[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
				set
				{
				}
			}

			[Token(Token = "0x1700138D")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool CollectStats
			{
				[Token(Token = "0x6005BFF")]
				[Address(RVA = "0x7F9A60", Offset = "0x7F8E60", VA = "0x1807F9A60")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6005C00")]
				[Address(RVA = "0x7F9A70", Offset = "0x7F8E70", VA = "0x1807F9A70")]
				set
				{
				}
			}

			[Token(Token = "0x6005BFA")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Success()
			{
			}

			[Token(Token = "0x6005BFB")]
			[Address(RVA = "0x9BDB80", Offset = "0x9BCF80", VA = "0x1809BDB80")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Success(Success other)
			{
			}

			[Token(Token = "0x6005BFC")]
			[Address(RVA = "0xB29320", Offset = "0xB28720", VA = "0x180B29320", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Success Clone()
			{
				return null;
			}

			[Token(Token = "0x6005C01")]
			[Address(RVA = "0xB293D0", Offset = "0xB287D0", VA = "0x180B293D0", Slot = "0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6005C02")]
			[Address(RVA = "0x9BD760", Offset = "0x9BCB60", VA = "0x1809BD760", Slot = "9")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool Equals(Success other)
			{
				return default(bool);
			}

			[Token(Token = "0x6005C03")]
			[Address(RVA = "0xB29480", Offset = "0xB28880", VA = "0x180B29480", Slot = "2")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6005C04")]
			[Address(RVA = "0xB29620", Offset = "0xB28A20", VA = "0x180B29620", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6005C05")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6005C06")]
			[Address(RVA = "0x9BDE30", Offset = "0x9BD230", VA = "0x1809BDE30", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6005C07")]
			[Address(RVA = "0xB29290", Offset = "0xB28690", VA = "0x180B29290", Slot = "7")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6005C08")]
			[Address(RVA = "0xB29540", Offset = "0xB28940", VA = "0x180B29540", Slot = "4")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(Success other)
			{
			}

			[Token(Token = "0x6005C09")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6005C0A")]
			[Address(RVA = "0xB29850", Offset = "0xB28C50", VA = "0x180B29850", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x4001DEB")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CharacterSelectionEvent> _parser;

	[Token(Token = "0x4001DEC")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001DED")]
	public const int ErrorFieldNumber = 1;

	[Token(Token = "0x4001DEE")]
	public const int SuccessFieldNumber = 2;

	[Token(Token = "0x4001DEF")]
	[FieldOffset(Offset = "0x18")]
	private object result_;

	[Token(Token = "0x4001DF0")]
	[FieldOffset(Offset = "0x20")]
	private ResultOneofCase resultCase_;

	[Token(Token = "0x17001380")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<CharacterSelectionEvent> Parser
	{
		[Token(Token = "0x6005BCC")]
		[Address(RVA = "0xB25440", Offset = "0xB24840", VA = "0x180B25440")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001381")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005BCD")]
		[Address(RVA = "0xB25330", Offset = "0xB24730", VA = "0x180B25330")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001382")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005BCE")]
		[Address(RVA = "0xB257D0", Offset = "0xB24BD0", VA = "0x180B257D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001383")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.Error Error
	{
		[Token(Token = "0x6005BD2")]
		[Address(RVA = "0xB253E0", Offset = "0xB247E0", VA = "0x180B253E0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005BD3")]
		[Address(RVA = "0x917DA0", Offset = "0x9171A0", VA = "0x180917DA0")]
		set
		{
		}
	}

	[Token(Token = "0x17001384")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.Success Success
	{
		[Token(Token = "0x6005BD4")]
		[Address(RVA = "0xB25490", Offset = "0xB24890", VA = "0x180B25490")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005BD5")]
		[Address(RVA = "0x917DE0", Offset = "0x9171E0", VA = "0x180917DE0")]
		set
		{
		}
	}

	[Token(Token = "0x17001385")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ResultOneofCase ResultCase
	{
		[Token(Token = "0x6005BD6")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(ResultOneofCase);
		}
	}

	[Token(Token = "0x6005BCF")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterSelectionEvent()
	{
	}

	[Token(Token = "0x6005BD0")]
	[Address(RVA = "0xB25100", Offset = "0xB24500", VA = "0x180B25100")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterSelectionEvent(CharacterSelectionEvent other)
	{
	}

	[Token(Token = "0x6005BD1")]
	[Address(RVA = "0xB24900", Offset = "0xB23D00", VA = "0x180B24900", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterSelectionEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6005BD7")]
	[Address(RVA = "0x916DD0", Offset = "0x9161D0", VA = "0x180916DD0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void ClearResult()
	{
	}

	[Token(Token = "0x6005BD8")]
	[Address(RVA = "0xB24A90", Offset = "0xB23E90", VA = "0x180B24A90", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005BD9")]
	[Address(RVA = "0xB24960", Offset = "0xB23D60", VA = "0x180B24960", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CharacterSelectionEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005BDA")]
	[Address(RVA = "0xB24C00", Offset = "0xB24000", VA = "0x180B24C00", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005BDB")]
	[Address(RVA = "0xB24FA0", Offset = "0xB243A0", VA = "0x180B24FA0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005BDC")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005BDD")]
	[Address(RVA = "0xB256C0", Offset = "0xB24AC0", VA = "0x180B256C0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005BDE")]
	[Address(RVA = "0xB247D0", Offset = "0xB23BD0", VA = "0x180B247D0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005BDF")]
	[Address(RVA = "0xB24D30", Offset = "0xB24130", VA = "0x180B24D30", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CharacterSelectionEvent other)
	{
	}

	[Token(Token = "0x6005BE0")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005BE1")]
	[Address(RVA = "0xB254F0", Offset = "0xB248F0", VA = "0x180B254F0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
