using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Mount;

[Token(Token = "0x200032F")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MountUpdateCharacteristicsEvent : IMessage<MountUpdateCharacteristicsEvent>, IMessage, IEquatable<MountUpdateCharacteristicsEvent>, IDeepCloneable<MountUpdateCharacteristicsEvent>, IBufferMessage
{
	[Token(Token = "0x2000330")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x2000331")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class MountCharacteristicUpdate : IMessage<MountCharacteristicUpdate>, IMessage, IEquatable<MountCharacteristicUpdate>, IDeepCloneable<MountCharacteristicUpdate>, IBufferMessage
		{
			[Token(Token = "0x4000B06")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<MountCharacteristicUpdate> _parser;

			[Token(Token = "0x4000B07")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x4000B08")]
			[FieldOffset(Offset = "0x18")]
			private int _hasBits0;

			[Token(Token = "0x4000B09")]
			public const int CharacteristicFieldNumber = 1;

			[Token(Token = "0x4000B0A")]
			[FieldOffset(Offset = "0x1C")]
			private MountCharacteristic characteristic_;

			[Token(Token = "0x4000B0B")]
			public const int IntValueFieldNumber = 2;

			[Token(Token = "0x4000B0C")]
			[FieldOffset(Offset = "0x8")]
			private static readonly int IntValueDefaultValue;

			[Token(Token = "0x4000B0D")]
			[FieldOffset(Offset = "0x20")]
			private int intValue_;

			[Token(Token = "0x17000712")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageParser<MountCharacteristicUpdate> Parser
			{
				[Token(Token = "0x6002101")]
				[Address(RVA = "0x97AE10", Offset = "0x97A210", VA = "0x18097AE10")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000713")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6002102")]
				[Address(RVA = "0x97AD20", Offset = "0x97A120", VA = "0x18097AD20")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000714")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6002103")]
				[Address(RVA = "0x97AF20", Offset = "0x97A320", VA = "0x18097AF20", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000715")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public MountCharacteristic Characteristic
			{
				[Token(Token = "0x6002107")]
				[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
				get
				{
					return default(MountCharacteristic);
				}
				[Token(Token = "0x6002108")]
				[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
				set
				{
				}
			}

			[Token(Token = "0x17000716")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int IntValue
			{
				[Token(Token = "0x6002109")]
				[Address(RVA = "0x97ADA0", Offset = "0x97A1A0", VA = "0x18097ADA0")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x600210A")]
				[Address(RVA = "0x939960", Offset = "0x938D60", VA = "0x180939960")]
				set
				{
				}
			}

			[Token(Token = "0x17000717")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool HasIntValue
			{
				[Token(Token = "0x600210B")]
				[Address(RVA = "0x87E8D0", Offset = "0x87DCD0", VA = "0x18087E8D0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6002104")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public MountCharacteristicUpdate()
			{
			}

			[Token(Token = "0x6002105")]
			[Address(RVA = "0x939530", Offset = "0x938930", VA = "0x180939530")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public MountCharacteristicUpdate(MountCharacteristicUpdate other)
			{
			}

			[Token(Token = "0x6002106")]
			[Address(RVA = "0x97A890", Offset = "0x979C90", VA = "0x18097A890", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public MountCharacteristicUpdate Clone()
			{
				return null;
			}

			[Token(Token = "0x600210C")]
			[Address(RVA = "0x92D290", Offset = "0x92C690", VA = "0x18092D290")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void ClearIntValue()
			{
			}

			[Token(Token = "0x600210D")]
			[Address(RVA = "0x97A9A0", Offset = "0x979DA0", VA = "0x18097A9A0", Slot = "0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x600210E")]
			[Address(RVA = "0x97A920", Offset = "0x979D20", VA = "0x18097A920", Slot = "9")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool Equals(MountCharacteristicUpdate other)
			{
				return default(bool);
			}

			[Token(Token = "0x600210F")]
			[Address(RVA = "0x97AA60", Offset = "0x979E60", VA = "0x18097AA60", Slot = "2")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6002110")]
			[Address(RVA = "0x97ABB0", Offset = "0x979FB0", VA = "0x18097ABB0", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6002111")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6002112")]
			[Address(RVA = "0x97AE60", Offset = "0x97A260", VA = "0x18097AE60", Slot = "12")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6002113")]
			[Address(RVA = "0x97A780", Offset = "0x979B80", VA = "0x18097A780", Slot = "7")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6002114")]
			[Address(RVA = "0x97AB40", Offset = "0x979F40", VA = "0x18097AB40", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(MountCharacteristicUpdate other)
			{
			}

			[Token(Token = "0x6002115")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6002116")]
			[Address(RVA = "0x939700", Offset = "0x938B00", VA = "0x180939700", Slot = "11")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x4000AFF")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<MountUpdateCharacteristicsEvent> _parser;

	[Token(Token = "0x4000B00")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000B01")]
	public const int RideIdFieldNumber = 1;

	[Token(Token = "0x4000B02")]
	[FieldOffset(Offset = "0x18")]
	private int rideId_;

	[Token(Token = "0x4000B03")]
	public const int UpdatedCharacteristicsFieldNumber = 2;

	[Token(Token = "0x4000B04")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<Types.MountCharacteristicUpdate> _repeated_updatedCharacteristics_codec;

	[Token(Token = "0x4000B05")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<Types.MountCharacteristicUpdate> updatedCharacteristics_;

	[Token(Token = "0x1700070D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MountUpdateCharacteristicsEvent> Parser
	{
		[Token(Token = "0x60020ED")]
		[Address(RVA = "0x97CA70", Offset = "0x97BE70", VA = "0x18097CA70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700070E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60020EE")]
		[Address(RVA = "0x97C9C0", Offset = "0x97BDC0", VA = "0x18097C9C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700070F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60020EF")]
		[Address(RVA = "0x97CCC0", Offset = "0x97C0C0", VA = "0x18097CCC0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000710")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int RideId
	{
		[Token(Token = "0x60020F3")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60020F4")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000711")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<Types.MountCharacteristicUpdate> UpdatedCharacteristics
	{
		[Token(Token = "0x60020F5")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60020F0")]
	[Address(RVA = "0x97C8B0", Offset = "0x97BCB0", VA = "0x18097C8B0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MountUpdateCharacteristicsEvent()
	{
	}

	[Token(Token = "0x60020F1")]
	[Address(RVA = "0x97C930", Offset = "0x97BD30", VA = "0x18097C930")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MountUpdateCharacteristicsEvent(MountUpdateCharacteristicsEvent other)
	{
	}

	[Token(Token = "0x60020F2")]
	[Address(RVA = "0x97C3E0", Offset = "0x97B7E0", VA = "0x18097C3E0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MountUpdateCharacteristicsEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60020F6")]
	[Address(RVA = "0x97C540", Offset = "0x97B940", VA = "0x18097C540", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60020F7")]
	[Address(RVA = "0x97C4A0", Offset = "0x97B8A0", VA = "0x18097C4A0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(MountUpdateCharacteristicsEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60020F8")]
	[Address(RVA = "0x971040", Offset = "0x970440", VA = "0x180971040", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60020F9")]
	[Address(RVA = "0x97C6B0", Offset = "0x97BAB0", VA = "0x18097C6B0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60020FA")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60020FB")]
	[Address(RVA = "0x97CBF0", Offset = "0x97BFF0", VA = "0x18097CBF0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60020FC")]
	[Address(RVA = "0x97C300", Offset = "0x97B700", VA = "0x18097C300", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60020FD")]
	[Address(RVA = "0x97C620", Offset = "0x97BA20", VA = "0x18097C620", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MountUpdateCharacteristicsEvent other)
	{
	}

	[Token(Token = "0x60020FE")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60020FF")]
	[Address(RVA = "0x97CAC0", Offset = "0x97BEC0", VA = "0x18097CAC0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
