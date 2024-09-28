using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight;

[Token(Token = "0x20005F5")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightScenarioEvent : IMessage<FightScenarioEvent>, IMessage, IEquatable<FightScenarioEvent>, IDeepCloneable<FightScenarioEvent>, IBufferMessage
{
	[Token(Token = "0x20005F6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x20005F7")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class ScenarioEntity : IMessage<ScenarioEntity>, IMessage, IEquatable<ScenarioEntity>, IDeepCloneable<ScenarioEntity>, IBufferMessage
		{
			[Token(Token = "0x40014E4")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<ScenarioEntity> _parser;

			[Token(Token = "0x40014E5")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x40014E6")]
			public const int ActorIdFieldNumber = 1;

			[Token(Token = "0x40014E7")]
			[FieldOffset(Offset = "0x18")]
			private long actorId_;

			[Token(Token = "0x40014E8")]
			public const int ScenarioIdFieldNumber = 2;

			[Token(Token = "0x40014E9")]
			[FieldOffset(Offset = "0x20")]
			private int scenarioId_;

			[Token(Token = "0x17000DB1")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<ScenarioEntity> Parser
			{
				[Token(Token = "0x6003FBF")]
				[Address(RVA = "0xA51F80", Offset = "0xA51380", VA = "0x180A51F80")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000DB2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6003FC0")]
				[Address(RVA = "0xA51F00", Offset = "0xA51300", VA = "0x180A51F00")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000DB3")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6003FC1")]
				[Address(RVA = "0xA51FD0", Offset = "0xA513D0", VA = "0x180A51FD0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000DB4")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public long ActorId
			{
				[Token(Token = "0x6003FC5")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x6003FC6")]
				[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
				set
				{
				}
			}

			[Token(Token = "0x17000DB5")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int ScenarioId
			{
				[Token(Token = "0x6003FC7")]
				[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6003FC8")]
				[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
				set
				{
				}
			}

			[Token(Token = "0x6003FC2")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public ScenarioEntity()
			{
			}

			[Token(Token = "0x6003FC3")]
			[Address(RVA = "0x948CF0", Offset = "0x9480F0", VA = "0x180948CF0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public ScenarioEntity(ScenarioEntity other)
			{
			}

			[Token(Token = "0x6003FC4")]
			[Address(RVA = "0xA51C70", Offset = "0xA51070", VA = "0x180A51C70", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public ScenarioEntity Clone()
			{
				return null;
			}

			[Token(Token = "0x6003FC9")]
			[Address(RVA = "0xA51D00", Offset = "0xA51100", VA = "0x180A51D00", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003FCA")]
			[Address(RVA = "0x9489C0", Offset = "0x947DC0", VA = "0x1809489C0", Slot = "9")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool Equals(ScenarioEntity other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003FCB")]
			[Address(RVA = "0x948AA0", Offset = "0x947EA0", VA = "0x180948AA0", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6003FCC")]
			[Address(RVA = "0xA51DA0", Offset = "0xA511A0", VA = "0x180A51DA0", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6003FCD")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6003FCE")]
			[Address(RVA = "0x9E9520", Offset = "0x9E8920", VA = "0x1809E9520", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6003FCF")]
			[Address(RVA = "0xA51BB0", Offset = "0xA50FB0", VA = "0x180A51BB0", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6003FD0")]
			[Address(RVA = "0x948B30", Offset = "0x947F30", VA = "0x180948B30", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(ScenarioEntity other)
			{
			}

			[Token(Token = "0x6003FD1")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6003FD2")]
			[Address(RVA = "0x948E20", Offset = "0x948220", VA = "0x180948E20", Slot = "11")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x40014DF")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FightScenarioEvent> _parser;

	[Token(Token = "0x40014E0")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40014E1")]
	public const int ScenariosFieldNumber = 1;

	[Token(Token = "0x40014E2")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<Types.ScenarioEntity> _repeated_scenarios_codec;

	[Token(Token = "0x40014E3")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<Types.ScenarioEntity> scenarios_;

	[Token(Token = "0x17000DAD")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FightScenarioEvent> Parser
	{
		[Token(Token = "0x6003FAD")]
		[Address(RVA = "0xA49540", Offset = "0xA48940", VA = "0x180A49540")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DAE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6003FAE")]
		[Address(RVA = "0xA49490", Offset = "0xA48890", VA = "0x180A49490")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DAF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6003FAF")]
		[Address(RVA = "0xA49750", Offset = "0xA48B50", VA = "0x180A49750", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DB0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<Types.ScenarioEntity> Scenarios
	{
		[Token(Token = "0x6003FB3")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003FB0")]
	[Address(RVA = "0xA49380", Offset = "0xA48780", VA = "0x180A49380")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightScenarioEvent()
	{
	}

	[Token(Token = "0x6003FB1")]
	[Address(RVA = "0xA49400", Offset = "0xA48800", VA = "0x180A49400")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightScenarioEvent(FightScenarioEvent other)
	{
	}

	[Token(Token = "0x6003FB2")]
	[Address(RVA = "0xA48ED0", Offset = "0xA482D0", VA = "0x180A48ED0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightScenarioEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6003FB4")]
	[Address(RVA = "0xA49020", Offset = "0xA48420", VA = "0x180A49020", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003FB5")]
	[Address(RVA = "0xA48F90", Offset = "0xA48390", VA = "0x180A48F90", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FightScenarioEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003FB6")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6003FB7")]
	[Address(RVA = "0xA49180", Offset = "0xA48580", VA = "0x180A49180", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6003FB8")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6003FB9")]
	[Address(RVA = "0xA496A0", Offset = "0xA48AA0", VA = "0x180A496A0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6003FBA")]
	[Address(RVA = "0xA48E30", Offset = "0xA48230", VA = "0x180A48E30", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6003FBB")]
	[Address(RVA = "0xA49100", Offset = "0xA48500", VA = "0x180A49100", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(FightScenarioEvent other)
	{
	}

	[Token(Token = "0x6003FBC")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6003FBD")]
	[Address(RVA = "0xA49590", Offset = "0xA48990", VA = "0x180A49590", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
