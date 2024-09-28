using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Server;

[Token(Token = "0x200014F")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ServerSessionConstantsEvent : IMessage<ServerSessionConstantsEvent>, IMessage, IEquatable<ServerSessionConstantsEvent>, IDeepCloneable<ServerSessionConstantsEvent>, IBufferMessage
{
	[Token(Token = "0x2000150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x2000151")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class ServerSessionConstant : IMessage<ServerSessionConstant>, IMessage, IEquatable<ServerSessionConstant>, IDeepCloneable<ServerSessionConstant>, IBufferMessage
		{
			[Token(Token = "0x4000483")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<ServerSessionConstant> _parser;

			[Token(Token = "0x4000484")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x4000485")]
			public const int IdFieldNumber = 1;

			[Token(Token = "0x4000486")]
			[FieldOffset(Offset = "0x18")]
			private int id_;

			[Token(Token = "0x4000487")]
			public const int ValueFieldNumber = 2;

			[Token(Token = "0x4000488")]
			[FieldOffset(Offset = "0x20")]
			private long value_;

			[Token(Token = "0x170002CF")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageParser<ServerSessionConstant> Parser
			{
				[Token(Token = "0x6000D18")]
				[Address(RVA = "0xC53C30", Offset = "0xC53030", VA = "0x180C53C30")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170002D0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6000D19")]
				[Address(RVA = "0xC53BB0", Offset = "0xC52FB0", VA = "0x180C53BB0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170002D1")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6000D1A")]
				[Address(RVA = "0xC53C80", Offset = "0xC53080", VA = "0x180C53C80", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170002D2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int Id
			{
				[Token(Token = "0x6000D1E")]
				[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6000D1F")]
				[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
				set
				{
				}
			}

			[Token(Token = "0x170002D3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public long Value
			{
				[Token(Token = "0x6000D20")]
				[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x6000D21")]
				[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
				set
				{
				}
			}

			[Token(Token = "0x6000D1B")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public ServerSessionConstant()
			{
			}

			[Token(Token = "0x6000D1C")]
			[Address(RVA = "0x950DA0", Offset = "0x9501A0", VA = "0x180950DA0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public ServerSessionConstant(ServerSessionConstant other)
			{
			}

			[Token(Token = "0x6000D1D")]
			[Address(RVA = "0xC53920", Offset = "0xC52D20", VA = "0x180C53920", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public ServerSessionConstant Clone()
			{
				return null;
			}

			[Token(Token = "0x6000D22")]
			[Address(RVA = "0xC539B0", Offset = "0xC52DB0", VA = "0x180C539B0", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6000D23")]
			[Address(RVA = "0x950A70", Offset = "0x94FE70", VA = "0x180950A70", Slot = "9")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool Equals(ServerSessionConstant other)
			{
				return default(bool);
			}

			[Token(Token = "0x6000D24")]
			[Address(RVA = "0x950B50", Offset = "0x94FF50", VA = "0x180950B50", Slot = "2")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6000D25")]
			[Address(RVA = "0xC53A50", Offset = "0xC52E50", VA = "0x180C53A50", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6000D26")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6000D27")]
			[Address(RVA = "0x950F80", Offset = "0x950380", VA = "0x180950F80", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6000D28")]
			[Address(RVA = "0xC53860", Offset = "0xC52C60", VA = "0x180C53860", Slot = "7")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6000D29")]
			[Address(RVA = "0x950BE0", Offset = "0x94FFE0", VA = "0x180950BE0", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(ServerSessionConstant other)
			{
			}

			[Token(Token = "0x6000D2A")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6000D2B")]
			[Address(RVA = "0x950ED0", Offset = "0x9502D0", VA = "0x180950ED0", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x400047E")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ServerSessionConstantsEvent> _parser;

	[Token(Token = "0x400047F")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000480")]
	public const int VariablesFieldNumber = 1;

	[Token(Token = "0x4000481")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<Types.ServerSessionConstant> _repeated_variables_codec;

	[Token(Token = "0x4000482")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<Types.ServerSessionConstant> variables_;

	[Token(Token = "0x170002CB")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ServerSessionConstantsEvent> Parser
	{
		[Token(Token = "0x6000D06")]
		[Address(RVA = "0xC54440", Offset = "0xC53840", VA = "0x180C54440")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002CC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000D07")]
		[Address(RVA = "0xC54390", Offset = "0xC53790", VA = "0x180C54390")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002CD")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000D08")]
		[Address(RVA = "0xC54650", Offset = "0xC53A50", VA = "0x180C54650", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002CE")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<Types.ServerSessionConstant> Variables
	{
		[Token(Token = "0x6000D0C")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000D09")]
	[Address(RVA = "0xC54280", Offset = "0xC53680", VA = "0x180C54280")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ServerSessionConstantsEvent()
	{
	}

	[Token(Token = "0x6000D0A")]
	[Address(RVA = "0xC54300", Offset = "0xC53700", VA = "0x180C54300")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ServerSessionConstantsEvent(ServerSessionConstantsEvent other)
	{
	}

	[Token(Token = "0x6000D0B")]
	[Address(RVA = "0xC53DD0", Offset = "0xC531D0", VA = "0x180C53DD0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ServerSessionConstantsEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6000D0D")]
	[Address(RVA = "0xC53F20", Offset = "0xC53320", VA = "0x180C53F20", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000D0E")]
	[Address(RVA = "0xC53E90", Offset = "0xC53290", VA = "0x180C53E90", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ServerSessionConstantsEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000D0F")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000D10")]
	[Address(RVA = "0xC54080", Offset = "0xC53480", VA = "0x180C54080", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000D11")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000D12")]
	[Address(RVA = "0xC545A0", Offset = "0xC539A0", VA = "0x180C545A0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000D13")]
	[Address(RVA = "0xC53D30", Offset = "0xC53130", VA = "0x180C53D30", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000D14")]
	[Address(RVA = "0xC54000", Offset = "0xC53400", VA = "0x180C54000", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ServerSessionConstantsEvent other)
	{
	}

	[Token(Token = "0x6000D15")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000D16")]
	[Address(RVA = "0xC54490", Offset = "0xC53890", VA = "0x180C54490", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
