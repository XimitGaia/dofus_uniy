using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact;

[Token(Token = "0x20007F4")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class UnBlockEvent : IMessage<UnBlockEvent>, IMessage, IEquatable<UnBlockEvent>, IDeepCloneable<UnBlockEvent>, IBufferMessage
{
	[Token(Token = "0x20007F5")]
	public enum ResultOneofCase
	{
		[Token(Token = "0x4001B77")]
		None,
		[Token(Token = "0x4001B78")]
		Error,
		[Token(Token = "0x4001B79")]
		Success
	}

	[Token(Token = "0x20007F6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x20007F7")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class Error : IMessage<Error>, IMessage, IEquatable<Error>, IDeepCloneable<Error>, IBufferMessage
		{
			[Token(Token = "0x4001B7A")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<Error> _parser;

			[Token(Token = "0x4001B7B")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x170011F9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageParser<Error> Parser
			{
				[Token(Token = "0x600547E")]
				[Address(RVA = "0xAECB90", Offset = "0xAEBF90", VA = "0x180AECB90")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170011FA")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x600547F")]
				[Address(RVA = "0xAECAC0", Offset = "0xAEBEC0", VA = "0x180AECAC0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170011FB")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6005480")]
				[Address(RVA = "0xAECE90", Offset = "0xAEC290", VA = "0x180AECE90", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6005481")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Error()
			{
			}

			[Token(Token = "0x6005482")]
			[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Error(Error other)
			{
			}

			[Token(Token = "0x6005483")]
			[Address(RVA = "0xAEC0A0", Offset = "0xAEB4A0", VA = "0x180AEC0A0", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Error Clone()
			{
				return null;
			}

			[Token(Token = "0x6005484")]
			[Address(RVA = "0xAEC340", Offset = "0xAEB740", VA = "0x180AEC340", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6005485")]
			[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool Equals(Error other)
			{
				return default(bool);
			}

			[Token(Token = "0x6005486")]
			[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6005487")]
			[Address(RVA = "0xAEC3C0", Offset = "0xAEB7C0", VA = "0x180AEC3C0", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6005488")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6005489")]
			[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x600548A")]
			[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x600548B")]
			[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(Error other)
			{
			}

			[Token(Token = "0x600548C")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x600548D")]
			[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}

		[Token(Token = "0x20007F9")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class Success : IMessage<Success>, IMessage, IEquatable<Success>, IDeepCloneable<Success>, IBufferMessage
		{
			[Token(Token = "0x4001B7D")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<Success> _parser;

			[Token(Token = "0x4001B7E")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x4001B7F")]
			public const int TagFieldNumber = 1;

			[Token(Token = "0x4001B80")]
			[FieldOffset(Offset = "0x18")]
			private AccountTag tag_;

			[Token(Token = "0x170011FC")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageParser<Success> Parser
			{
				[Token(Token = "0x6005492")]
				[Address(RVA = "0xAF5850", Offset = "0xAF4C50", VA = "0x180AF5850")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170011FD")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6005493")]
				[Address(RVA = "0xAF56D0", Offset = "0xAF4AD0", VA = "0x180AF56D0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170011FE")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6005494")]
				[Address(RVA = "0xAF5E40", Offset = "0xAF5240", VA = "0x180AF5E40", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170011FF")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public AccountTag Tag
			{
				[Token(Token = "0x6005498")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return null;
				}
				[Token(Token = "0x6005499")]
				[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
				set
				{
				}
			}

			[Token(Token = "0x6005495")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Success()
			{
			}

			[Token(Token = "0x6005496")]
			[Address(RVA = "0xAF5570", Offset = "0xAF4970", VA = "0x180AF5570")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public Success(Success other)
			{
			}

			[Token(Token = "0x6005497")]
			[Address(RVA = "0xAF48B0", Offset = "0xAF3CB0", VA = "0x180AF48B0", Slot = "10")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public Success Clone()
			{
				return null;
			}

			[Token(Token = "0x600549A")]
			[Address(RVA = "0xAF4C00", Offset = "0xAF4000", VA = "0x180AF4C00", Slot = "0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x600549B")]
			[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool Equals(Success other)
			{
				return default(bool);
			}

			[Token(Token = "0x600549C")]
			[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x600549D")]
			[Address(RVA = "0xAF4FF0", Offset = "0xAF43F0", VA = "0x180AF4FF0", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x600549E")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x600549F")]
			[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x60054A0")]
			[Address(RVA = "0xAF4650", Offset = "0xAF3A50", VA = "0x180AF4650", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x60054A1")]
			[Address(RVA = "0xAF4CB0", Offset = "0xAF40B0", VA = "0x180AF4CB0", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(Success other)
			{
			}

			[Token(Token = "0x60054A2")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x60054A3")]
			[Address(RVA = "0xAF5990", Offset = "0xAF4D90", VA = "0x180AF5990", Slot = "11")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x4001B70")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<UnBlockEvent> _parser;

	[Token(Token = "0x4001B71")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001B72")]
	public const int ErrorFieldNumber = 1;

	[Token(Token = "0x4001B73")]
	public const int SuccessFieldNumber = 2;

	[Token(Token = "0x4001B74")]
	[FieldOffset(Offset = "0x18")]
	private object result_;

	[Token(Token = "0x4001B75")]
	[FieldOffset(Offset = "0x20")]
	private ResultOneofCase resultCase_;

	[Token(Token = "0x170011F3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<UnBlockEvent> Parser
	{
		[Token(Token = "0x6005467")]
		[Address(RVA = "0xAF8AC0", Offset = "0xAF7EC0", VA = "0x180AF8AC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170011F4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005468")]
		[Address(RVA = "0xAF89B0", Offset = "0xAF7DB0", VA = "0x180AF89B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170011F5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005469")]
		[Address(RVA = "0xAF8E50", Offset = "0xAF8250", VA = "0x180AF8E50", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170011F6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.Error Error
	{
		[Token(Token = "0x600546D")]
		[Address(RVA = "0xAF8A60", Offset = "0xAF7E60", VA = "0x180AF8A60")]
		get
		{
			return null;
		}
		[Token(Token = "0x600546E")]
		[Address(RVA = "0x917DA0", Offset = "0x9171A0", VA = "0x180917DA0")]
		set
		{
		}
	}

	[Token(Token = "0x170011F7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.Success Success
	{
		[Token(Token = "0x600546F")]
		[Address(RVA = "0xAF8B10", Offset = "0xAF7F10", VA = "0x180AF8B10")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005470")]
		[Address(RVA = "0x917DE0", Offset = "0x9171E0", VA = "0x180917DE0")]
		set
		{
		}
	}

	[Token(Token = "0x170011F8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ResultOneofCase ResultCase
	{
		[Token(Token = "0x6005471")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(ResultOneofCase);
		}
	}

	[Token(Token = "0x600546A")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public UnBlockEvent()
	{
	}

	[Token(Token = "0x600546B")]
	[Address(RVA = "0xAF8780", Offset = "0xAF7B80", VA = "0x180AF8780")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UnBlockEvent(UnBlockEvent other)
	{
	}

	[Token(Token = "0x600546C")]
	[Address(RVA = "0xAF7F80", Offset = "0xAF7380", VA = "0x180AF7F80", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UnBlockEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6005472")]
	[Address(RVA = "0x916DD0", Offset = "0x9161D0", VA = "0x180916DD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearResult()
	{
	}

	[Token(Token = "0x6005473")]
	[Address(RVA = "0xAF7FE0", Offset = "0xAF73E0", VA = "0x180AF7FE0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005474")]
	[Address(RVA = "0xAF8150", Offset = "0xAF7550", VA = "0x180AF8150", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(UnBlockEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005475")]
	[Address(RVA = "0xAF8280", Offset = "0xAF7680", VA = "0x180AF8280", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005476")]
	[Address(RVA = "0xAF8620", Offset = "0xAF7A20", VA = "0x180AF8620", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005477")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005478")]
	[Address(RVA = "0xAF8D40", Offset = "0xAF8140", VA = "0x180AF8D40", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005479")]
	[Address(RVA = "0xAF7E50", Offset = "0xAF7250", VA = "0x180AF7E50", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600547A")]
	[Address(RVA = "0xAF83B0", Offset = "0xAF77B0", VA = "0x180AF83B0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(UnBlockEvent other)
	{
	}

	[Token(Token = "0x600547B")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600547C")]
	[Address(RVA = "0xAF8B70", Offset = "0xAF7F70", VA = "0x180AF8B70", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
