using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact;

[Token(Token = "0x20007E2")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class UnIgnoreEvent : IMessage<UnIgnoreEvent>, IMessage, IEquatable<UnIgnoreEvent>, IDeepCloneable<UnIgnoreEvent>, IBufferMessage
{
	[Token(Token = "0x20007E3")]
	public enum ResultOneofCase
	{
		[Token(Token = "0x4001B49")]
		None,
		[Token(Token = "0x4001B4A")]
		Error,
		[Token(Token = "0x4001B4B")]
		Success
	}

	[Token(Token = "0x20007E4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x20007E5")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class Error : IMessage<Error>, IMessage, IEquatable<Error>, IDeepCloneable<Error>, IBufferMessage
		{
			[Token(Token = "0x4001B4C")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<Error> _parser;

			[Token(Token = "0x4001B4D")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x170011DA")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<Error> Parser
			{
				[Token(Token = "0x60053DF")]
				[Address(RVA = "0xAECC30", Offset = "0xAEC030", VA = "0x180AECC30")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170011DB")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x60053E0")]
				[Address(RVA = "0xAEC9C0", Offset = "0xAEBDC0", VA = "0x180AEC9C0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170011DC")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x60053E1")]
				[Address(RVA = "0xAECDE0", Offset = "0xAEC1E0", VA = "0x180AECDE0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60053E2")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Error()
			{
			}

			[Token(Token = "0x60053E3")]
			[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Error(Error other)
			{
			}

			[Token(Token = "0x60053E4")]
			[Address(RVA = "0xAEC120", Offset = "0xAEB520", VA = "0x180AEC120", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Error Clone()
			{
				return null;
			}

			[Token(Token = "0x60053E5")]
			[Address(RVA = "0xAEC230", Offset = "0xAEB630", VA = "0x180AEC230", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x60053E6")]
			[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(Error other)
			{
				return default(bool);
			}

			[Token(Token = "0x60053E7")]
			[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x60053E8")]
			[Address(RVA = "0xAEC4B0", Offset = "0xAEB8B0", VA = "0x180AEC4B0", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x60053E9")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x60053EA")]
			[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x60053EB")]
			[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x60053EC")]
			[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(Error other)
			{
			}

			[Token(Token = "0x60053ED")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x60053EE")]
			[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}

		[Token(Token = "0x20007E7")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class Success : IMessage<Success>, IMessage, IEquatable<Success>, IDeepCloneable<Success>, IBufferMessage
		{
			[Token(Token = "0x4001B4F")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<Success> _parser;

			[Token(Token = "0x4001B50")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x4001B51")]
			public const int IgnoredTagFieldNumber = 1;

			[Token(Token = "0x4001B52")]
			[FieldOffset(Offset = "0x18")]
			private AccountTag ignoredTag_;

			[Token(Token = "0x170011DD")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<Success> Parser
			{
				[Token(Token = "0x60053F3")]
				[Address(RVA = "0xAF58F0", Offset = "0xAF4CF0", VA = "0x180AF58F0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170011DE")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x60053F4")]
				[Address(RVA = "0xAF5750", Offset = "0xAF4B50", VA = "0x180AF5750")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170011DF")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x60053F5")]
				[Address(RVA = "0xAF5D90", Offset = "0xAF5190", VA = "0x180AF5D90", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170011E0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public AccountTag IgnoredTag
			{
				[Token(Token = "0x60053F9")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return null;
				}
				[Token(Token = "0x60053FA")]
				[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
				set
				{
				}
			}

			[Token(Token = "0x60053F6")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public Success()
			{
			}

			[Token(Token = "0x60053F7")]
			[Address(RVA = "0xAF5570", Offset = "0xAF4970", VA = "0x180AF5570")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Success(Success other)
			{
			}

			[Token(Token = "0x60053F8")]
			[Address(RVA = "0xAF4950", Offset = "0xAF3D50", VA = "0x180AF4950", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Success Clone()
			{
				return null;
			}

			[Token(Token = "0x60053FB")]
			[Address(RVA = "0xAF49F0", Offset = "0xAF3DF0", VA = "0x180AF49F0", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x60053FC")]
			[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(Success other)
			{
				return default(bool);
			}

			[Token(Token = "0x60053FD")]
			[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x60053FE")]
			[Address(RVA = "0xAF5040", Offset = "0xAF4440", VA = "0x180AF5040", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x60053FF")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6005400")]
			[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6005401")]
			[Address(RVA = "0xAF46E0", Offset = "0xAF3AE0", VA = "0x180AF46E0", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6005402")]
			[Address(RVA = "0xAF4E50", Offset = "0xAF4250", VA = "0x180AF4E50", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(Success other)
			{
			}

			[Token(Token = "0x6005403")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6005404")]
			[Address(RVA = "0xAF5C90", Offset = "0xAF5090", VA = "0x180AF5C90", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x4001B42")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<UnIgnoreEvent> _parser;

	[Token(Token = "0x4001B43")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001B44")]
	public const int ErrorFieldNumber = 1;

	[Token(Token = "0x4001B45")]
	public const int SuccessFieldNumber = 2;

	[Token(Token = "0x4001B46")]
	[FieldOffset(Offset = "0x18")]
	private object result_;

	[Token(Token = "0x4001B47")]
	[FieldOffset(Offset = "0x20")]
	private ResultOneofCase resultCase_;

	[Token(Token = "0x170011D4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<UnIgnoreEvent> Parser
	{
		[Token(Token = "0x60053C8")]
		[Address(RVA = "0xAF9FE0", Offset = "0xAF93E0", VA = "0x180AF9FE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170011D5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60053C9")]
		[Address(RVA = "0xAF9ED0", Offset = "0xAF92D0", VA = "0x180AF9ED0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170011D6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60053CA")]
		[Address(RVA = "0xAFA370", Offset = "0xAF9770", VA = "0x180AFA370", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170011D7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.Error Error
	{
		[Token(Token = "0x60053CE")]
		[Address(RVA = "0xAF9F80", Offset = "0xAF9380", VA = "0x180AF9F80")]
		get
		{
			return null;
		}
		[Token(Token = "0x60053CF")]
		[Address(RVA = "0x917DA0", Offset = "0x9171A0", VA = "0x180917DA0")]
		set
		{
		}
	}

	[Token(Token = "0x170011D8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.Success Success
	{
		[Token(Token = "0x60053D0")]
		[Address(RVA = "0xAFA030", Offset = "0xAF9430", VA = "0x180AFA030")]
		get
		{
			return null;
		}
		[Token(Token = "0x60053D1")]
		[Address(RVA = "0x917DE0", Offset = "0x9171E0", VA = "0x180917DE0")]
		set
		{
		}
	}

	[Token(Token = "0x170011D9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ResultOneofCase ResultCase
	{
		[Token(Token = "0x60053D2")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(ResultOneofCase);
		}
	}

	[Token(Token = "0x60053CB")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UnIgnoreEvent()
	{
	}

	[Token(Token = "0x60053CC")]
	[Address(RVA = "0xAF9CA0", Offset = "0xAF90A0", VA = "0x180AF9CA0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UnIgnoreEvent(UnIgnoreEvent other)
	{
	}

	[Token(Token = "0x60053CD")]
	[Address(RVA = "0xAF94A0", Offset = "0xAF88A0", VA = "0x180AF94A0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public UnIgnoreEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60053D3")]
	[Address(RVA = "0x916DD0", Offset = "0x9161D0", VA = "0x180916DD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearResult()
	{
	}

	[Token(Token = "0x60053D4")]
	[Address(RVA = "0xAF9500", Offset = "0xAF8900", VA = "0x180AF9500", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60053D5")]
	[Address(RVA = "0xAF9670", Offset = "0xAF8A70", VA = "0x180AF9670", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(UnIgnoreEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60053D6")]
	[Address(RVA = "0xAF97A0", Offset = "0xAF8BA0", VA = "0x180AF97A0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60053D7")]
	[Address(RVA = "0xAF9B40", Offset = "0xAF8F40", VA = "0x180AF9B40", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60053D8")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60053D9")]
	[Address(RVA = "0xAFA260", Offset = "0xAF9660", VA = "0x180AFA260", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60053DA")]
	[Address(RVA = "0xAF9370", Offset = "0xAF8770", VA = "0x180AF9370", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60053DB")]
	[Address(RVA = "0xAF98D0", Offset = "0xAF8CD0", VA = "0x180AF98D0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(UnIgnoreEvent other)
	{
	}

	[Token(Token = "0x60053DC")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60053DD")]
	[Address(RVA = "0xAFA090", Offset = "0xAF9490", VA = "0x180AFA090", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
