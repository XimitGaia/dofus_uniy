using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Achievement;

[Token(Token = "0x2000D2E")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class Achievement : IMessage<Achievement>, IMessage, IEquatable<Achievement>, IDeepCloneable<Achievement>, IBufferMessage
{
	[Token(Token = "0x2000D2F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x2000D30")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class AchievementObjective : IMessage<AchievementObjective>, IMessage, IEquatable<AchievementObjective>, IDeepCloneable<AchievementObjective>, IBufferMessage
		{
			[Token(Token = "0x400304F")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<AchievementObjective> _parser;

			[Token(Token = "0x4003050")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x4003051")]
			[FieldOffset(Offset = "0x18")]
			private int _hasBits0;

			[Token(Token = "0x4003052")]
			public const int ObjectiveIdFieldNumber = 1;

			[Token(Token = "0x4003053")]
			[FieldOffset(Offset = "0x1C")]
			private int objectiveId_;

			[Token(Token = "0x4003054")]
			public const int MaxValueFieldNumber = 2;

			[Token(Token = "0x4003055")]
			[FieldOffset(Offset = "0x20")]
			private long maxValue_;

			[Token(Token = "0x4003056")]
			public const int CurrentValueFieldNumber = 3;

			[Token(Token = "0x4003057")]
			[FieldOffset(Offset = "0x8")]
			private static readonly long CurrentValueDefaultValue;

			[Token(Token = "0x4003058")]
			[FieldOffset(Offset = "0x28")]
			private long currentValue_;

			[Token(Token = "0x17001E4C")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<AchievementObjective> Parser
			{
				[Token(Token = "0x6008ADA")]
				[Address(RVA = "0xCBB8A0", Offset = "0xCBACA0", VA = "0x180CBB8A0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001E4D")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6008ADB")]
				[Address(RVA = "0xCBB820", Offset = "0xCBAC20", VA = "0x180CBB820")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001E4E")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6008ADC")]
				[Address(RVA = "0xCBBAB0", Offset = "0xCBAEB0", VA = "0x180CBBAB0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001E4F")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int ObjectiveId
			{
				[Token(Token = "0x6008AE0")]
				[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6008AE1")]
				[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
				set
				{
				}
			}

			[Token(Token = "0x17001E50")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public long MaxValue
			{
				[Token(Token = "0x6008AE2")]
				[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x6008AE3")]
				[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
				set
				{
				}
			}

			[Token(Token = "0x17001E51")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public long CurrentValue
			{
				[Token(Token = "0x6008AE4")]
				[Address(RVA = "0xCBB7B0", Offset = "0xCBABB0", VA = "0x180CBB7B0")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x6008AE5")]
				[Address(RVA = "0x960DE0", Offset = "0x9601E0", VA = "0x180960DE0")]
				set
				{
				}
			}

			[Token(Token = "0x17001E52")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool HasCurrentValue
			{
				[Token(Token = "0x6008AE6")]
				[Address(RVA = "0x87E8D0", Offset = "0x87DCD0", VA = "0x18087E8D0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6008ADD")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public AchievementObjective()
			{
			}

			[Token(Token = "0x6008ADE")]
			[Address(RVA = "0xA3BF60", Offset = "0xA3B360", VA = "0x180A3BF60")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public AchievementObjective(AchievementObjective other)
			{
			}

			[Token(Token = "0x6008ADF")]
			[Address(RVA = "0xCBB2D0", Offset = "0xCBA6D0", VA = "0x180CBB2D0", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public AchievementObjective Clone()
			{
				return null;
			}

			[Token(Token = "0x6008AE7")]
			[Address(RVA = "0x92D290", Offset = "0x92C690", VA = "0x18092D290")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void ClearCurrentValue()
			{
			}

			[Token(Token = "0x6008AE8")]
			[Address(RVA = "0xCBB370", Offset = "0xCBA770", VA = "0x180CBB370", Slot = "0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6008AE9")]
			[Address(RVA = "0xCBB440", Offset = "0xCBA840", VA = "0x180CBB440", Slot = "9")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool Equals(AchievementObjective other)
			{
				return default(bool);
			}

			[Token(Token = "0x6008AEA")]
			[Address(RVA = "0xCBB4D0", Offset = "0xCBA8D0", VA = "0x180CBB4D0", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6008AEB")]
			[Address(RVA = "0xCBB640", Offset = "0xCBAA40", VA = "0x180CBB640", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6008AEC")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6008AED")]
			[Address(RVA = "0xCBB9C0", Offset = "0xCBADC0", VA = "0x180CBB9C0", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6008AEE")]
			[Address(RVA = "0xCBB190", Offset = "0xCBA590", VA = "0x180CBB190", Slot = "7")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6008AEF")]
			[Address(RVA = "0xCBB5D0", Offset = "0xCBA9D0", VA = "0x180CBB5D0", Slot = "4")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(AchievementObjective other)
			{
			}

			[Token(Token = "0x6008AF0")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6008AF1")]
			[Address(RVA = "0xCBB8F0", Offset = "0xCBACF0", VA = "0x180CBB8F0", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x4003048")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<Achievement> _parser;

	[Token(Token = "0x4003049")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400304A")]
	public const int AchievementIdFieldNumber = 1;

	[Token(Token = "0x400304B")]
	[FieldOffset(Offset = "0x18")]
	private int achievementId_;

	[Token(Token = "0x400304C")]
	public const int AchievementObjectivesFieldNumber = 2;

	[Token(Token = "0x400304D")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<Types.AchievementObjective> _repeated_achievementObjectives_codec;

	[Token(Token = "0x400304E")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<Types.AchievementObjective> achievementObjectives_;

	[Token(Token = "0x17001E47")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<Achievement> Parser
	{
		[Token(Token = "0x6008AC6")]
		[Address(RVA = "0xCA57F0", Offset = "0xCA4BF0", VA = "0x180CA57F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001E48")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6008AC7")]
		[Address(RVA = "0xCA5740", Offset = "0xCA4B40", VA = "0x180CA5740")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001E49")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6008AC8")]
		[Address(RVA = "0xCA5A40", Offset = "0xCA4E40", VA = "0x180CA5A40", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001E4A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int AchievementId
	{
		[Token(Token = "0x6008ACC")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6008ACD")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17001E4B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<Types.AchievementObjective> AchievementObjectives
	{
		[Token(Token = "0x6008ACE")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6008AC9")]
	[Address(RVA = "0xCA5630", Offset = "0xCA4A30", VA = "0x180CA5630")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Achievement()
	{
	}

	[Token(Token = "0x6008ACA")]
	[Address(RVA = "0xCA56B0", Offset = "0xCA4AB0", VA = "0x180CA56B0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Achievement(Achievement other)
	{
	}

	[Token(Token = "0x6008ACB")]
	[Address(RVA = "0xCA5160", Offset = "0xCA4560", VA = "0x180CA5160", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Achievement Clone()
	{
		return null;
	}

	[Token(Token = "0x6008ACF")]
	[Address(RVA = "0xCA5220", Offset = "0xCA4620", VA = "0x180CA5220", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008AD0")]
	[Address(RVA = "0xCA5300", Offset = "0xCA4700", VA = "0x180CA5300", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(Achievement other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008AD1")]
	[Address(RVA = "0x971040", Offset = "0x970440", VA = "0x180971040", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6008AD2")]
	[Address(RVA = "0xCA5430", Offset = "0xCA4830", VA = "0x180CA5430", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6008AD3")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6008AD4")]
	[Address(RVA = "0xCA5970", Offset = "0xCA4D70", VA = "0x180CA5970", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6008AD5")]
	[Address(RVA = "0xCA5080", Offset = "0xCA4480", VA = "0x180CA5080", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6008AD6")]
	[Address(RVA = "0xCA53A0", Offset = "0xCA47A0", VA = "0x180CA53A0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(Achievement other)
	{
	}

	[Token(Token = "0x6008AD7")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6008AD8")]
	[Address(RVA = "0xCA5840", Offset = "0xCA4C40", VA = "0x180CA5840", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
