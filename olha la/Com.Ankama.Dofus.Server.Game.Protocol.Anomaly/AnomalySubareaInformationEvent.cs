using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Anomaly;

[Token(Token = "0x2000C37")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AnomalySubareaInformationEvent : IMessage<AnomalySubareaInformationEvent>, IMessage, IEquatable<AnomalySubareaInformationEvent>, IDeepCloneable<AnomalySubareaInformationEvent>, IBufferMessage
{
	[Token(Token = "0x2000C38")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x2000C39")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class AnomalySubareaInformation : IMessage<AnomalySubareaInformation>, IMessage, IEquatable<AnomalySubareaInformation>, IDeepCloneable<AnomalySubareaInformation>, IBufferMessage
		{
			[Token(Token = "0x4002D59")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<AnomalySubareaInformation> _parser;

			[Token(Token = "0x4002D5A")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x4002D5B")]
			public const int SubareaIdFieldNumber = 1;

			[Token(Token = "0x4002D5C")]
			[FieldOffset(Offset = "0x18")]
			private int subareaId_;

			[Token(Token = "0x4002D5D")]
			public const int RewardRateFieldNumber = 2;

			[Token(Token = "0x4002D5E")]
			[FieldOffset(Offset = "0x1C")]
			private int rewardRate_;

			[Token(Token = "0x4002D5F")]
			public const int HasAnomalyFieldNumber = 3;

			[Token(Token = "0x4002D60")]
			[FieldOffset(Offset = "0x20")]
			private bool hasAnomaly_;

			[Token(Token = "0x4002D61")]
			public const int AnomalyClosingTimeFieldNumber = 4;

			[Token(Token = "0x4002D62")]
			[FieldOffset(Offset = "0x28")]
			private long anomalyClosingTime_;

			[Token(Token = "0x17001C3D")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<AnomalySubareaInformation> Parser
			{
				[Token(Token = "0x60080A7")]
				[Address(RVA = "0xC85AE0", Offset = "0xC84EE0", VA = "0x180C85AE0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001C3E")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x60080A8")]
				[Address(RVA = "0xC85A60", Offset = "0xC84E60", VA = "0x180C85A60")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001C3F")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x60080A9")]
				[Address(RVA = "0xC85CF0", Offset = "0xC850F0", VA = "0x180C85CF0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001C40")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int SubareaId
			{
				[Token(Token = "0x60080AD")]
				[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x60080AE")]
				[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
				set
				{
				}
			}

			[Token(Token = "0x17001C41")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int RewardRate
			{
				[Token(Token = "0x60080AF")]
				[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x60080B0")]
				[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
				set
				{
				}
			}

			[Token(Token = "0x17001C42")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool HasAnomaly
			{
				[Token(Token = "0x60080B1")]
				[Address(RVA = "0x7F9A60", Offset = "0x7F8E60", VA = "0x1807F9A60")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60080B2")]
				[Address(RVA = "0x7F9A70", Offset = "0x7F8E70", VA = "0x1807F9A70")]
				set
				{
				}
			}

			[Token(Token = "0x17001C43")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public long AnomalyClosingTime
			{
				[Token(Token = "0x60080B3")]
				[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x60080B4")]
				[Address(RVA = "0x972C70", Offset = "0x972070", VA = "0x180972C70")]
				set
				{
				}
			}

			[Token(Token = "0x60080AA")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public AnomalySubareaInformation()
			{
			}

			[Token(Token = "0x60080AB")]
			[Address(RVA = "0xC859F0", Offset = "0xC84DF0", VA = "0x180C859F0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public AnomalySubareaInformation(AnomalySubareaInformation other)
			{
			}

			[Token(Token = "0x60080AC")]
			[Address(RVA = "0xC85590", Offset = "0xC84990", VA = "0x180C85590", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public AnomalySubareaInformation Clone()
			{
				return null;
			}

			[Token(Token = "0x60080B5")]
			[Address(RVA = "0xC85620", Offset = "0xC84A20", VA = "0x180C85620", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x60080B6")]
			[Address(RVA = "0xC856D0", Offset = "0xC84AD0", VA = "0x180C856D0", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(AnomalySubareaInformation other)
			{
				return default(bool);
			}

			[Token(Token = "0x60080B7")]
			[Address(RVA = "0xC85720", Offset = "0xC84B20", VA = "0x180C85720", Slot = "2")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x60080B8")]
			[Address(RVA = "0xC85890", Offset = "0xC84C90", VA = "0x180C85890", Slot = "3")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x60080B9")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x60080BA")]
			[Address(RVA = "0xC85C30", Offset = "0xC85030", VA = "0x180C85C30", Slot = "12")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x60080BB")]
			[Address(RVA = "0xC854A0", Offset = "0xC848A0", VA = "0x180C854A0", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x60080BC")]
			[Address(RVA = "0xC85820", Offset = "0xC84C20", VA = "0x180C85820", Slot = "4")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(AnomalySubareaInformation other)
			{
			}

			[Token(Token = "0x60080BD")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x60080BE")]
			[Address(RVA = "0xC85B30", Offset = "0xC84F30", VA = "0x180C85B30", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x4002D54")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AnomalySubareaInformationEvent> _parser;

	[Token(Token = "0x4002D55")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002D56")]
	public const int SubareasFieldNumber = 1;

	[Token(Token = "0x4002D57")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<Types.AnomalySubareaInformation> _repeated_subareas_codec;

	[Token(Token = "0x4002D58")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<Types.AnomalySubareaInformation> subareas_;

	[Token(Token = "0x17001C39")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AnomalySubareaInformationEvent> Parser
	{
		[Token(Token = "0x6008095")]
		[Address(RVA = "0xC84E10", Offset = "0xC84210", VA = "0x180C84E10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C3A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6008096")]
		[Address(RVA = "0xC84D60", Offset = "0xC84160", VA = "0x180C84D60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C3B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6008097")]
		[Address(RVA = "0xC85020", Offset = "0xC84420", VA = "0x180C85020", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C3C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<Types.AnomalySubareaInformation> Subareas
	{
		[Token(Token = "0x600809B")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6008098")]
	[Address(RVA = "0xC84CE0", Offset = "0xC840E0", VA = "0x180C84CE0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AnomalySubareaInformationEvent()
	{
	}

	[Token(Token = "0x6008099")]
	[Address(RVA = "0xC84C50", Offset = "0xC84050", VA = "0x180C84C50")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AnomalySubareaInformationEvent(AnomalySubareaInformationEvent other)
	{
	}

	[Token(Token = "0x600809A")]
	[Address(RVA = "0xC847A0", Offset = "0xC83BA0", VA = "0x180C847A0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AnomalySubareaInformationEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600809C")]
	[Address(RVA = "0xC848F0", Offset = "0xC83CF0", VA = "0x180C848F0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600809D")]
	[Address(RVA = "0xC84860", Offset = "0xC83C60", VA = "0x180C84860", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(AnomalySubareaInformationEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600809E")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600809F")]
	[Address(RVA = "0xC84A50", Offset = "0xC83E50", VA = "0x180C84A50", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60080A0")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60080A1")]
	[Address(RVA = "0xC84F70", Offset = "0xC84370", VA = "0x180C84F70", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60080A2")]
	[Address(RVA = "0xC84700", Offset = "0xC83B00", VA = "0x180C84700", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60080A3")]
	[Address(RVA = "0xC849D0", Offset = "0xC83DD0", VA = "0x180C849D0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AnomalySubareaInformationEvent other)
	{
	}

	[Token(Token = "0x60080A4")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60080A5")]
	[Address(RVA = "0xC84E60", Offset = "0xC84260", VA = "0x180C84E60", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
