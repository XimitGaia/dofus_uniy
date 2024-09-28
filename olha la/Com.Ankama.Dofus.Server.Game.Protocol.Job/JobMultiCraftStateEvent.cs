using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Job;

[Token(Token = "0x2000353")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class JobMultiCraftStateEvent : IMessage<JobMultiCraftStateEvent>, IMessage, IEquatable<JobMultiCraftStateEvent>, IDeepCloneable<JobMultiCraftStateEvent>, IBufferMessage
{
	[Token(Token = "0x2000354")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x2000355")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class PlayerSkills : IMessage<PlayerSkills>, IMessage, IEquatable<PlayerSkills>, IDeepCloneable<PlayerSkills>, IBufferMessage
		{
			[Token(Token = "0x4000B77")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<PlayerSkills> _parser;

			[Token(Token = "0x4000B78")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x4000B79")]
			public const int PlayerIdFieldNumber = 1;

			[Token(Token = "0x4000B7A")]
			[FieldOffset(Offset = "0x18")]
			private long playerId_;

			[Token(Token = "0x4000B7B")]
			public const int SkillsFieldNumber = 2;

			[Token(Token = "0x4000B7C")]
			[FieldOffset(Offset = "0x8")]
			private static readonly FieldCodec<int> _repeated_skills_codec;

			[Token(Token = "0x4000B7D")]
			[FieldOffset(Offset = "0x20")]
			private readonly RepeatedField<int> skills_;

			[Token(Token = "0x17000763")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageParser<PlayerSkills> Parser
			{
				[Token(Token = "0x6002281")]
				[Address(RVA = "0x97D470", Offset = "0x97C870", VA = "0x18097D470")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000764")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6002282")]
				[Address(RVA = "0x97D3F0", Offset = "0x97C7F0", VA = "0x18097D3F0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000765")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6002283")]
				[Address(RVA = "0x97D6C0", Offset = "0x97CAC0", VA = "0x18097D6C0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000766")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public long PlayerId
			{
				[Token(Token = "0x6002287")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x6002288")]
				[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
				set
				{
				}
			}

			[Token(Token = "0x17000767")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public RepeatedField<int> Skills
			{
				[Token(Token = "0x6002289")]
				[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6002284")]
			[Address(RVA = "0x97D370", Offset = "0x97C770", VA = "0x18097D370")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public PlayerSkills()
			{
			}

			[Token(Token = "0x6002285")]
			[Address(RVA = "0x97D2D0", Offset = "0x97C6D0", VA = "0x18097D2D0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public PlayerSkills(PlayerSkills other)
			{
			}

			[Token(Token = "0x6002286")]
			[Address(RVA = "0x97CDE0", Offset = "0x97C1E0", VA = "0x18097CDE0", Slot = "10")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public PlayerSkills Clone()
			{
				return null;
			}

			[Token(Token = "0x600228A")]
			[Address(RVA = "0x97CEA0", Offset = "0x97C2A0", VA = "0x18097CEA0", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x600228B")]
			[Address(RVA = "0x97CF80", Offset = "0x97C380", VA = "0x18097CF80", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(PlayerSkills other)
			{
				return default(bool);
			}

			[Token(Token = "0x600228C")]
			[Address(RVA = "0x97D020", Offset = "0x97C420", VA = "0x18097D020", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x600228D")]
			[Address(RVA = "0x97D140", Offset = "0x97C540", VA = "0x18097D140", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x600228E")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x600228F")]
			[Address(RVA = "0x97D5F0", Offset = "0x97C9F0", VA = "0x18097D5F0", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6002290")]
			[Address(RVA = "0x97CD00", Offset = "0x97C100", VA = "0x18097CD00", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6002291")]
			[Address(RVA = "0x97D0B0", Offset = "0x97C4B0", VA = "0x18097D0B0", Slot = "4")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(PlayerSkills other)
			{
			}

			[Token(Token = "0x6002292")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6002293")]
			[Address(RVA = "0x97D4C0", Offset = "0x97C8C0", VA = "0x18097D4C0", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x4000B71")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<JobMultiCraftStateEvent> _parser;

	[Token(Token = "0x4000B72")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000B73")]
	public const int EnabledFieldNumber = 1;

	[Token(Token = "0x4000B74")]
	[FieldOffset(Offset = "0x18")]
	private bool enabled_;

	[Token(Token = "0x4000B75")]
	public const int PlayerSkillsFieldNumber = 2;

	[Token(Token = "0x4000B76")]
	[FieldOffset(Offset = "0x20")]
	private Types.PlayerSkills playerSkills_;

	[Token(Token = "0x1700075E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<JobMultiCraftStateEvent> Parser
	{
		[Token(Token = "0x600226C")]
		[Address(RVA = "0x974840", Offset = "0x973C40", VA = "0x180974840")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700075F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600226D")]
		[Address(RVA = "0x974790", Offset = "0x973B90", VA = "0x180974790")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000760")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600226E")]
		[Address(RVA = "0x974A40", Offset = "0x973E40", VA = "0x180974A40", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000761")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Enabled
	{
		[Token(Token = "0x6002272")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002273")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x17000762")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.PlayerSkills PlayerSkills
	{
		[Token(Token = "0x6002274")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002275")]
		[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
		set
		{
		}
	}

	[Token(Token = "0x600226F")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JobMultiCraftStateEvent()
	{
	}

	[Token(Token = "0x6002270")]
	[Address(RVA = "0x974670", Offset = "0x973A70", VA = "0x180974670")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JobMultiCraftStateEvent(JobMultiCraftStateEvent other)
	{
	}

	[Token(Token = "0x6002271")]
	[Address(RVA = "0x9740A0", Offset = "0x9734A0", VA = "0x1809740A0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JobMultiCraftStateEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6002276")]
	[Address(RVA = "0x9741F0", Offset = "0x9735F0", VA = "0x1809741F0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002277")]
	[Address(RVA = "0x9742A0", Offset = "0x9736A0", VA = "0x1809742A0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JobMultiCraftStateEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002278")]
	[Address(RVA = "0x974310", Offset = "0x973710", VA = "0x180974310", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002279")]
	[Address(RVA = "0x974510", Offset = "0x973910", VA = "0x180974510", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600227A")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600227B")]
	[Address(RVA = "0x9749C0", Offset = "0x973DC0", VA = "0x1809749C0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600227C")]
	[Address(RVA = "0x974000", Offset = "0x973400", VA = "0x180974000", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600227D")]
	[Address(RVA = "0x9743D0", Offset = "0x9737D0", VA = "0x1809743D0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JobMultiCraftStateEvent other)
	{
	}

	[Token(Token = "0x600227E")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600227F")]
	[Address(RVA = "0x974890", Offset = "0x973C90", VA = "0x180974890", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
